// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint4.Task4.V23
// Description: Реализация интерфейса ISprint4Task4V23 — замена нечётных элементов массива на 0.

using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task4.V14.Lib
{
    public class DataService : ISprint4Task4V14
    {
        /// <summary>
        /// Заменяет все нечётные элементы массива на 0.
        /// </summary>
        public int[,] Calculate(int[,] matrix)
        {
            if (matrix == null) throw new ArgumentNullException(nameof(matrix));

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = (matrix[i, j] % 2 == 0) ? matrix[i, j] : 0;
                }
            }

            return result;
        }

       
    }
}