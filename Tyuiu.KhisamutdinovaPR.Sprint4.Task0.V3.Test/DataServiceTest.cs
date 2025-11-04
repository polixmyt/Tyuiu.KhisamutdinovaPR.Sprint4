using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhisamutdinovaPR.Sprint4.Task0.V3.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMultOddArrEl()
        {
            DataService ds = new DataService();
            int[] array = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
            int res = ds.GetMultOddArrEl(array);
            int expected = 9 * 1 * 3 * 5 * 7; // 945
            Assert.AreEqual(expected, res);
        }
    }
}