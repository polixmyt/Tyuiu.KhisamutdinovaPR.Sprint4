using System;
using Tyuiu.KhisamutdinovaPR.Sprint4.Task1.V16.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task1.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[] array = new int[13];

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнила: Хисамутдинова Полина                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите 13 целых чисел в диапазоне от 3 до 8:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"array[{i}] = ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int result = ds.Calculate(array);

            Console.WriteLine();
            Console.WriteLine("Произведение нечётных элементов массива = " + result);
            Console.ReadKey();
        }
    }
}