// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint4.Task5.V23
// Description: Реализация интерфейса ISprint4Task5V23 — подсчёт количества положительных элементов в матрице.

using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task5.V19.Lib
{
    public class DataService : ISprint4Task5V19
    {
        /// <summary>
        /// Возвращает количество положительных элементов ( > 0 ) в матрице.
        /// </summary>
        public int Calculate(int[,] matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            int count = 0;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                        count++;
                }
            }

            return count;
        }
    }
}