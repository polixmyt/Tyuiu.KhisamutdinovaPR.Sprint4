using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint4.Task1.V16.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 4, 3, 7, 3, 7, 4, 3, 3, 4, 4, 8, 3, 4 };
            int res = ds.Calculate(array);

            int expected = 3 * 7 * 3 * 7 * 3 * 3 * 3; // произведение всех нечётных = 23877
            Assert.AreEqual(expected, res);
        }
    }
}