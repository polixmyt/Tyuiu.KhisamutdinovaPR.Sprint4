// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint4.Task6.V7
// Description: Подсчёт количества строк длиной > 8 с использованием класса Array.

using System;
using Tyuiu.KhisamutdinovaPR.Sprint4.Task6.V7.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task6.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 4 | Таск 6 | Вариант 7 — Подсчёт длинных строк";

            string[] array = new string[]
            {
                "Математика",
                "Физика",
                "Химия",
                "Биология",
                "География",
                "История",
                "Экономика"
            };

            DataService ds = new DataService();
            int result = ds.Calculate(array);

            Console.WriteLine("Строковый массив:");
            Console.WriteLine("--------------------------------");
            Array.ForEach(array, s => Console.WriteLine(s));
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Количество элементов длиной > 8: {result}");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}