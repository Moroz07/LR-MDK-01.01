

using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;

namespace Matrix_DZ
{
    internal class Program
    {

        /// Вывод матрицы на консоль 
        
        static void Main()
        {
            /// Создаем матрицу 2 на 2
            Matrix matrix_2x2 = new Matrix();
            matrix_2x2.CreatingMatrix(2, 2);
            Console.WriteLine("Первая матрица: ");
            matrix_2x2.SetMatrix(0, 0, 1);
            matrix_2x2.SetMatrix(0, 1, 2);
            matrix_2x2.SetMatrix(1, 0, 3);
            matrix_2x2.SetMatrix(1, 1, 4);
            matrix_2x2.Print();
            Console.WriteLine("Определитель: " + matrix_2x2.Determinant());
            Console.WriteLine();


            /// Создаем матрицу 2 на 3
            Matrix matrix_2x3 = new Matrix();
            matrix_2x3.CreatingMatrix(2, 3);
            Console.WriteLine("Вторая матрица: ");
            matrix_2x3.SetMatrix(0, 0, 5);
            matrix_2x3.SetMatrix(0, 1, 6);
            matrix_2x3.SetMatrix(0, 2, 7);
            matrix_2x3.SetMatrix(1, 0, 8);
            matrix_2x3.SetMatrix(1, 1, 9);
            matrix_2x3.SetMatrix(1, 2, 10);
            matrix_2x3.Print();
            Console.WriteLine("Результат умножения");
            Matrix result = MatrixMultiplication(matrix_2x2, matrix_2x3);
            result.Print();

            Console.WriteLine();
            Console.WriteLine("              🚗 FORD FOCUS 3 🚗");
            Console.WriteLine();
            Console.WriteLine("               ___________________");
            Console.WriteLine("              /                   \\");
            Console.WriteLine("             /                     \\");
            Console.WriteLine("            /                       \\");
            Console.WriteLine("           /                         \\");
            Console.WriteLine("          /                           \\");
            Console.WriteLine("         /                             \\");
            Console.WriteLine("        /                               \\");
            Console.WriteLine("       /                                 \\");
            Console.WriteLine("      /                                   \\");
            Console.WriteLine("     /                                     \\");
            Console.WriteLine("    /                                       \\");
            Console.WriteLine("   /_________________________________________\\");
            Console.WriteLine("  | |                                       | |");
            Console.WriteLine("  | |    ┌─────────────────────────────────┐ | |");
            Console.WriteLine("  | |    │                                 │ | |");
            Console.WriteLine("  | |    │   ███████████████████████████   │ | |");
            Console.WriteLine("  | |    │   ███ ●         ●         ● ███ │ | |");
            Console.WriteLine("  | |    │   ███                       ███ │ | |");
            Console.WriteLine("  | |    │   ███   ┌───────────────┐   ███ │ | |");
            Console.WriteLine("  | |    │   ███   │    F O R D    │   ███ │ | |");
            Console.WriteLine("  | |    │   ███   └───────────────┘   ███ │ | |");
            Console.WriteLine("  | |    │   ███                       ███ │ | |");
            Console.WriteLine("  | |    │   ███████████████████████████   │ | |");
            Console.WriteLine("  | |    │                                 │ | |");
            Console.WriteLine("  | |    └─────────────────────────────────┘ | |");
            Console.WriteLine("  | |                                       | |");
            Console.WriteLine("  | |_______________________________________| |");
            Console.WriteLine("  |___________________________________________|");
            Console.WriteLine();
            Console.WriteLine("         💨 Ready for matrix math! 💨");

        }
        /// Функция умножения матриц
        static public Matrix MatrixMultiplication(Matrix a, Matrix b)
        {
            if(a.GetColumns() != b.GetRows())
            {
                Console.WriteLine("Такое нельзя умножить !!!");
                return null;
            }

            Matrix result = new Matrix();
            result.CreatingMatrix(a.GetRows(), b.GetColumns());

            for (int i = 0; i < a.GetRows(); i++)
            {
                for(int j = 0; j < b.GetColumns(); j++)
                {
                    int summ =0;
                    for(int k = 0; k < a.GetColumns(); k++)
                    {
                        summ += a.GetMatrix(i, k) * b.GetMatrix(k, j);
                    }
                    result.SetMatrix(i, j, summ);
                }

            }
            return result;
            
        }
        
       
    }
}
