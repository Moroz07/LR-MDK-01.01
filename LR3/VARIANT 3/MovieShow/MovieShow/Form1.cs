using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieShow
{
    public partial class MainForm : Form
    {
        List<Movie> actionmovie = new List<Movie>();
        List<Movie> fantasy = new List<Movie>(); 
        public MainForm()
        {
            InitializeComponent();
            actionmovie.Add(new Movie ("Трансформеры", 250, "Майкл Бэй", "Шайа Лабаф", new DateTime(2025, 01, 30)));
            actionmovie.Add(new Movie("Брат 2", 300, "Алексей Балабанов", "Сергей Бодров", new DateTime(2025, 01, 31)));
            fantasy.Add(new Movie("Человек-паук: Через вселенные",  270, "Родни Ротман", "Шамеик Мур", new DateTime(2025, 02, 01)));
            fantasy.Add(new Movie("Последний богатырь",  220, "Дмитрий Дьяченко", "Виктор Хориняк", new DateTime(2025, 02, 01)));

            ListBoxGenre.Items.Add("Боевик");
            ListBoxGenre.Items.Add("Фэнтези");



        }

        private void ListBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxMovie.Items.Clear();

            string selectedGenre = ListBoxGenre.SelectedItem.ToString();

            if (selectedGenre == "Боевик")
            {
                foreach (Movie movie in actionmovie)
                {
                    ComboBoxMovie.Items.Add(movie.Name);
                }
            }
            else if (selectedGenre == "Фэнтези")
            {
                foreach (Movie movie in fantasy)
                {
                    ComboBoxMovie.Items.Add(movie.Name);
                }
            }

            if (ComboBoxMovie.Items.Count != 0)
            {
                ComboBoxMovie.SelectedIndex = 0;
            }
        }

        

        private void ButtonShowMovie_Click(object sender, EventArgs e)
        {
            if (ComboBoxMovie.SelectedItem != null && ListBoxGenre.SelectedItem != null)
            {
                string selectedMovieName = ComboBoxMovie.SelectedItem.ToString();
                string selectedGenre = ListBoxGenre.SelectedItem.ToString();

                Movie selectedMovie = null;

                if (selectedGenre == "Боевик")
                {
                    foreach (Movie movie in actionmovie)
                    {
                        if (movie.Name == selectedMovieName)
                        {
                            selectedMovie = movie;
                            break;
                        }
                    }
                }
                else if (selectedGenre == "Фэнтези")
                {
                    foreach (Movie movie in fantasy)
                    {
                        if (movie.Name == selectedMovieName)
                        {
                            selectedMovie = movie;
                            break;
                        }
                    }
                }

                if (selectedMovie != null)
                {

                    RichTextBoxInfo.Text = selectedMovie.GetInfo();
                }
            }
        }
    }
}
