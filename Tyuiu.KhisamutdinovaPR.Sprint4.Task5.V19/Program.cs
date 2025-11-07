// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint4.Task5.V23
// Description: Консольный ввод и подсчёт количества положительных элементов в 2D массиве.

using System;
using Tyuiu.KhisamutdinovaPR.Sprint4.Task5.V19.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task5.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 4 | Таск 5 | Вариант 23 — Подсчёт положительных элементов";

            DataService ds = new DataService();
            Random rnd = new Random();

            int[,] matrix = new int[5, 5];

            // Заполнение массива случайными числами от -2 до 3
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rnd.Next(-2, 4); // диапазон [-2; 3]
                }
            }

            Console.WriteLine("Исходная матрица 5x5:");
            PrintMatrix(matrix);

            int result = ds.Calculate(matrix);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Количество положительных элементов: {result}");
            Console.WriteLine("--------------------------------------");
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