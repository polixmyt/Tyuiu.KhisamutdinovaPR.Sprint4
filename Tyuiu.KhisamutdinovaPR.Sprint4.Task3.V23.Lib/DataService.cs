// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint4.Task3.V23
// Description: Реализация интерфейса ISprint4Task3V23 — подсчёт чётных элементов в одномерном массиве.

using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task3.V23.Lib
{
    public class DataService : ISprint4Task1V23
    {
        /// <summary>
        /// Подсчитывает количество чётных элементов в одномерном массиве.
        /// </summary>
        public int Calculate(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int countEven = 0;

            foreach (int number in array)
            {
                if (number % 2 == 0)
                    countEven++;
            }

            return countEven;
        }
    }
}