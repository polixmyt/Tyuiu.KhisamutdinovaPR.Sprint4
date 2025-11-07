using System;
using Tyuiu.KhisamutdinovaPR.Sprint4.Task3.V23.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task3.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 4 | Таск 3 | Вариант 23 — Количество чётных в 2D массиве";

            // Статический ввод по условию
            int[,] matrix = new int[5, 5]
            {
                { 7, 5, 5, 6, 7 },
                { 8, 7, 8, 4, 3 },
                { 5, 6, 7, 8, 3 },
                { 4, 2, 3, 6, 4 },
                { 5, 2, 4, 2, 3 }
            };

            DataService ds = new DataService();
            int evenCount = ds.Calculate(matrix);

            // Оформление по шаблону репозитория: чёткий вывод результата
            Console.WriteLine("Двумерные массивы (статический ввод)");
            Console.WriteLine("Спринт: 4 | Задание: 3 | Вариант: 23");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Матрица 5x5 (2..8) задана статически.");
            Console.WriteLine($"Количество чётных элементов: {evenCount}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}