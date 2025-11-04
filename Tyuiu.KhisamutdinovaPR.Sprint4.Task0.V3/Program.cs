using System;
using Tyuiu.KhisamutdinovaPR.Sprint4.Task0.V3.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task0.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[] array = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнила: Хисамутдинова Полина                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            int result = ds.GetMultOddArrEl(array);
            Console.WriteLine("Произведение нечётных элементов массива = " + result);

            Console.ReadKey();
        }
    }
}