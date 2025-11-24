

using System;

namespace Matrix_DZ
{
    public class Matrix
    {
        /// Создали атрибуты класса
        private int[,] numbers_;
        private int rows_;
        private int colums_;
        

        /// Создание матрицы
        public void CreatingMatrix (int row, int colum)
        {
            rows_ = row;
            colums_ = colum;
            numbers_ = new int[rows_, colums_];
        }
        ///Записываем число в саму матрицу(в ячейку)
        public void SetMatrix(int row,int colum,int value)
        {
            numbers_[row,colum] = value;
        }
        /// Выводим число из ячейки
        public int GetMatrix(int row,int colum)
        {
            return numbers_[row,colum];
        }
        
        public int GetRows()
        { 
            return rows_;
        }

        public  int GetColumns()
        {
            return colums_;
        }

        public int Determinant() //Нахождение определителя
        {
            if (!(rows_ == colums_))
            {
                Console.WriteLine("Матрица не квадратная !!! ");
                return 0;
            }
            if (rows_ == colums_)
            {
                if (rows_ == 1)
                {
                    return numbers_[0, 0];
                }
                if (rows_ == 2)
                {
                    return numbers_[0, 0] * numbers_[1, 1] - numbers_[0, 1] * numbers_[1, 0];
                }
            }
            return 0;
        }

        public void Print()
        {
            for (int i = 0; i < rows_; i++)
            {
                for (int j = 0; j < colums_; j++)
                {
                    Console.Write(numbers_[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


    }
}
