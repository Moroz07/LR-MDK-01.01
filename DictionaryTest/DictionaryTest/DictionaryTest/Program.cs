using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTest
{
    enum Genre
    {
        Drama,
        Tragic,
        Comedy,
        Unknown
    }
    internal class Program
    {
        static public void EditingBooks(Dictionary<Genre, List<string>> allBooks, string UserBook, string editBook)
        {
            foreach (List<string> books in allBooks.Values)
            {
                for (int index = 0; index < books.Count; ++index)
                {
                    if (books[index] == UserBook)
                    {
                        books[index] = editBook;
                    }
                }
            }
        }

        static public void AddBook(Dictionary<Genre, List<string>> allBooks, string NewBook)
        {
            foreach (List<string> books in allBooks.Values)
            {
                for (int index = 0; index < books.Count; ++index)
                {
                    if (books[index] == NewBook)
                    {
                        Console.WriteLine("Такая книга уже есть ");

                    }
                    else if (books[index] != NewBook)
                    {
                        books.Add(NewBook);
                        index++;
                    }
                }
            }
        }
        static public void RemoveBook(Dictionary<Genre, List<string>> allBooks, string bookName)
        {

            foreach (List<string> books in allBooks.Values)
            {
                for (int index = 0; index < books.Count; ++index)
                {
                    if (books[index] == bookName)
                    {
                        books.RemoveAt(index);
                        --index;
                    }
                }
            }
        }

        static void PrintBooksByGenre(Genre genre, Dictionary<Genre, List<string>> allBooks)
        {
            if (allBooks.ContainsKey(genre))
            {
                List<string> books = allBooks[genre];
                Console.WriteLine(String.Join("\n", books));
            }
            else
            {
                Console.WriteLine("Книг данного жанра мы еще не завезли");
            }
        }

        static private Genre MakeGenreByText(string text)
        {
            if (text == "драма")
            {
                return Genre.Drama;
            }

            if (text == "комедия")
            {
                return Genre.Comedy;
            }

            if (text == "трагедия")
            {
                return Genre.Tragic;
            }

            return Genre.Unknown;
        }

        static void Main(string[] args)
        {
            /// создали пустой словарь,
            /// где ключом выступает тип перечисления Genre,
            /// а значение список строковых значений (список названий книг)
            Dictionary<Genre, List<string>> catalogBooks =
                new Dictionary<Genre, List<string>>();

            /// заполнили книги жанра комедии
            catalogBooks.Add(Genre.Comedy,
                             new List<string>() { "Горе от ума",
                                                  "Вечера на хуторе близ Диканьки",
                                                  "Ревизор",
                                                  "Ум от горя"});

            /// заполнили книги жанра трагедии
            catalogBooks.Add(Genre.Tragic,
                 new List<string>() { "Сегодня суббота",
                                      "Трагедия понедельника"});

            Console.Write("Какой жанр литературы Вам интересен? ");
            string text = Console.ReadLine();
            Genre genre = MakeGenreByText(text);

            if (genre == Genre.Unknown)
            {
                Console.WriteLine("Ай я-яй, нужна либо драма, либо трагедия, либо комедия");
                return;
            }

            PrintBooksByGenre(genre, catalogBooks);

            Console.Write("Какую книгу хотите удалить?");
            Console.WriteLine();
            string bookRemove = Console.ReadLine();
            RemoveBook(catalogBooks, bookRemove);
            Console.WriteLine("Набор книг после удаления");
            Console.WriteLine();
            PrintBooksByGenre(genre, catalogBooks);

            Console.WriteLine("Какую книгу хотите добавить: ");
            string NewBook = Console.ReadLine();
            AddBook(catalogBooks, NewBook);
            PrintBooksByGenre(genre, catalogBooks);

            Console.WriteLine("Какую книгу изменяем: ");
            string UserBook = Console.ReadLine();
            Console.WriteLine("Как изменяем книгу: ");
            string editBook = Console.ReadLine();
            EditingBooks(catalogBooks, UserBook, editBook);
            PrintBooksByGenre(genre, catalogBooks);

        }
    }
}
