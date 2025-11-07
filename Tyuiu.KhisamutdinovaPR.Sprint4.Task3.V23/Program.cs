using System;
using Tyuiu.KhisamutdinovaPR.Sprint4.Task3.V23.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task3.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнила: Хисамутдинова Полина Руслановна | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнила: Хисамутдинова Полина Руслановна | ПКТб-25-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Подсчитать количество четных элементов в статическом массиве   *");
            Console.WriteLine("* 5x5 со значениями в диапазоне [2..8].                                   *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix =
            {
                { 7, 5, 5, 6, 7 },
                { 8, 7, 8, 4, 3 },
                { 5, 6, 7, 8, 3 },
                { 4, 2, 3, 6, 4 },
                { 5, 2, 4, 2, 3 }
            };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }

            var ds = new DataService();
            int result = ds.Calculate(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Количество четных элементов: {result}"); // должно вывести 13
            Console.ReadKey();
        }
    }
}