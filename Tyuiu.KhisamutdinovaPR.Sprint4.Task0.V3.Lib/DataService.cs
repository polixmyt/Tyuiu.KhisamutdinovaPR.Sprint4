using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task0.V3.Lib
{
    public class DataService : ISprint4Task0V3
    {
        public int GetMultOddArrEl(int[] array)
        {
            int mult = 1;
            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    mult *= num;
                }
            }
            return mult;
        }
    }
}