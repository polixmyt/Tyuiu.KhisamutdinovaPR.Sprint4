using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint4.Task3.V23.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] {
                { 7, 5, 5, 6, 7 },
                { 8, 7, 8, 4, 3 },
                { 5, 6, 7, 8, 3 },
                { 4, 2, 3, 6, 4 },
                { 5, 2, 4, 2, 3 }
            };

            int result = ds.Calculate(array);
            int wait = 13; // количество четных элементов в данном массиве

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateAllEven()
        {
            DataService ds = new DataService();

            int[,] array = new int[2, 2] {
                { 2, 4 },
                { 6, 8 }
            };

            int result = ds.Calculate(array);
            int wait = 4; // все элементы четные

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateNoEven()
        {
            DataService ds = new DataService();

            int[,] array = new int[2, 2] {
                { 3, 5 },
                { 7, 9 }
            };

            int result = ds.Calculate(array);
            int wait = 0; // нет четных элементов

            Assert.AreEqual(wait, result);
        }
    }
}