// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint4.Task7.V27
// Description: Реализация интерфейса ISprint4Task7V27 — преобразование строки в матрицу и подсчёт чётных элементов.

using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task7.V27.Lib
{
    public class DataService : ISprint4Task7V27
    {
        /// <summary>
        /// Преобразует строку цифр в матрицу n×m и возвращает количество чётных чисел.
        /// </summary>
        public int Calculate(int n, int m, string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Строка не должна быть пустой.", nameof(value));

            if (value.Length < n * m)
                throw new ArgumentException("Длина строки меньше требуемого размера матрицы.");

            int[,] matrix = new int[n, m];
            int index = 0;
            int countEven = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int number = Convert.ToInt32(value[index].ToString());
                    matrix[i, j] = number;
                    index++;

                    if (number % 2 == 0)
                        countEven++;
                }
            }

            return countEven;
        }
    }
}