// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint4.Task7.V27
// Description: Преобразование строки в матрицу 4×3 и подсчёт количества чётных чисел.

using System;
using Tyuiu.KhisamutdinovaPR.Sprint4.Task7.V27.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task7.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 4 | Таск 7 | Вариант 27 — Подсчёт чётных чисел из строки";

            DataService ds = new DataService();

            int n = 4;
            int m = 3;
            string value = "583197256891";

            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine($"Размер матрицы: {n}x{m}");
            Console.WriteLine("------------------------------------");

            int result = ds.Calculate(n, m, value);

            Console.WriteLine($"Количество чётных чисел: {result}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}