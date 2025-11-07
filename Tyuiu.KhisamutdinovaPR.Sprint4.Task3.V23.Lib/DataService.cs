// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint4.Task3.V23
// Description: Реализация интерфейса ISprint4Task3V23 — подсчёт количества чётных элементов в двумерном массиве.

using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task3.V23.Lib
{
    public class DataService : ISprint4Task3V23
    {
        /// <summary>
        /// Подсчитывает количество чётных элементов в двумерном массиве.
        /// </summary>
        /// <param name="array">Двумерный целочисленный массив.</param>
        /// <returns>Количество чётных элементов.</returns>
        public int Calculate(int[,] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Массив не должен быть пустым.");
            }

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int countEven = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        countEven++;
                    }
                }
            }

            return countEven;
        }
    }
}