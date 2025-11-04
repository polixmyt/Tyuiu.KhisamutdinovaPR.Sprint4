using System;

namespace Tyuiu.MargaryanSG.Sprint4.Task2.V5.Lib
{
    public class DataService
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasEven = false;

            foreach (int num in array)
            {
                if (num % 2 == 0) // проверка на четность
                {
                    product *= num;
                    hasEven = true;
                }
            }

            if (!hasEven)
            {
                return 0; // если нет четных элементов
            }

            return product;
        }
    }
}