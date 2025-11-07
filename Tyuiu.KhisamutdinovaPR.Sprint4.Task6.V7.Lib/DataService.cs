// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint4.Task6.V7
// Description: Реализация интерфейса ISprint4Task6V7 — подсчёт строк длиной > 8 символов.

using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task6.V7.Lib
{
    public class DataService : ISprint4Task6V7
    {
        /// <summary>
        /// Подсчитывает количество строк в массиве, длина которых больше 8 символов.
        /// </summary>
        public int Calculate(string[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int count = 0;

            // Используем класс Array и перебор через foreach
            foreach (string item in array)
            {
                if (item.Length > 8)
                    count++;
            }

            return count;
        }
    }
}