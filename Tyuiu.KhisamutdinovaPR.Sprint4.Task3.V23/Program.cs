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
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5x5 элементов, заполненный           *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 8. Подсчитать количество     *");
            Console.WriteLine("* четных элементов во всем массиве.                                       *");
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
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            DataService ds = new DataService();
            int result = ds.Calculate(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Количество четных элементов: {result}");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}