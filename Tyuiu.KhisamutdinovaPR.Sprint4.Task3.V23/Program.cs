// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint4.Task3.V23
// Description: Подсчёт количества чётных элементов в двумерном массиве (статический ввод).

using System;
using Tyuiu.KhisamutdinovaPR.Sprint4.Task3.V23.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task3.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 4 | Таск 3 | Вариант 23 — Подсчёт чётных элементов (2D массив)";

            int[,] array = new int[5, 5]
            {
                { 7, 5, 5, 6, 7 },
                { 8, 7, 8, 4, 3 },
                { 5, 6, 7, 8, 3 },
                { 4, 2, 3, 6, 4 },
                { 5, 2, 4, 2, 3 }
            };

            DataService ds = new DataService();

            try
            {
                int result = ds.Calculate(array);
                Console.WriteLine("Исходный массив 5x5:");
                PrintMatrix(array);

                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"Количество чётных элементов: {result}");
                Console.WriteLine("--------------------------------------");
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Метод Calculate() пока не реализован.");
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}