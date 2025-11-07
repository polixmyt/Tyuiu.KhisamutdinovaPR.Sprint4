// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint4.Task3.V23
// Description: Подсчёт количества чётных элементов в одномерном массиве (матрица 5x5 преобразована).

using System;
using Tyuiu.KhisamutdinovaPR.Sprint4.Task3.V23.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task3.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 4 | Таск 3 | Вариант 23 — Подсчёт чётных элементов";

            // Статические значения массива 5x5, записанные в одномерный массив
            int[] array = new int[]
            {
                7, 5, 5, 6, 7,
                8, 7, 8, 4, 3,
                5, 6, 7, 8, 3,
                4, 2, 3, 6, 4,
                5, 2, 4, 2, 3
            };

            DataService ds = new DataService();
            int result = ds.Calculate(array);

            Console.WriteLine("Исходные данные (матрица 5x5 в виде одномерного массива):");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i],4}");
                if ((i + 1) % 5 == 0)
                    Console.WriteLine();
            }

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Количество чётных элементов: {result}");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}