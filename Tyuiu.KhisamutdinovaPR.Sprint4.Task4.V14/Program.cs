// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint4.Task4.V23
// Description: Консольный ввод матрицы 5x5 и замена нечётных элементов на 0.

using System;
using Tyuiu.KhisamutdinovaPR.Sprint4.Task4.V14.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task4.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 4 | Таск 4 | Вариант 23 — Замена нечётных элементов на 0";

            Console.WriteLine("Введите элементы матрицы 5x5 (значения от 1 до 8):");
            int[,] matrix = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"[{i},{j}] = ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            DataService ds = new DataService();
            int[,] result = ds.Calculate(matrix);

            Console.WriteLine("\nИсходная матрица:");
            PrintMatrix(matrix);

            Console.WriteLine("\nРезультат (нечётные заменены на 0):");
            PrintMatrix(result);

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
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