using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MargaryanSG.Sprint4.Task2.V5.Lib;

namespace Tyuiu.MargaryanSG.Sprint4.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 4, 3, 6, 5, 8, 7, 9, 4, 3, 6, 8, 5, 4, 7 };
            int result = ds.Calculate(array);
            int wait = 4 * 6 * 8 * 4 * 6 * 8 * 4; // произведение четных элементов

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateNoEven()
        {
            DataService ds = new DataService();

            int[] array = { 3, 5, 7, 9, 3, 5, 7, 9, 3, 5, 7, 9, 3, 5 };
            int result = ds.Calculate(array);
            int wait = 0; // нет четных элементов

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateWithOneEven()
        {
            DataService ds = new DataService();

            int[] array = { 3, 5, 7, 4, 3, 5, 7, 9, 3, 5, 7, 9, 3, 5 };
            int result = ds.Calculate(array);
            int wait = 4; // только один четный элемент

            Assert.AreEqual(wait, result);
        }
    }
}