using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task1.V16.Lib
{
    public class DataService : ISprint4Task1V16
    {
        public int Calculate(int[] array)
        {
            int mult = 1;
            bool hasOdd = false;

            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    mult *= num;
                    hasOdd = true;
                }
            }

            if (!hasOdd)
            {
                mult = 0;
            }

            return mult;
        }
    }
}