using System;
using Tyuiu.KhisamutdinovaPR.Sprint4.Task3.V23.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task3.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] {
                { 7, 5, 5, 6, 7 },
                { 8, 7, 8, 4, 3 },
                { 5, 6, 7, 8, 3 },
                { 4, 2, 3, 6, 4 },
                { 5, 2, 4, 2, 3 }
            };

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Двумерный массив 5x5:");
            Console.WriteLine();

            // Вывод массива в красивом формате
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(array);
            Console.WriteLine("Количество четных элементов в массиве = " + result);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ПРОВЕРКА:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Четные элементы в массиве:");

            // Дополнительная проверка - покажем какие элементы считаются четными
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        Console.WriteLine($"array[{i},{j}] = {array[i, j]} (четный)");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}
