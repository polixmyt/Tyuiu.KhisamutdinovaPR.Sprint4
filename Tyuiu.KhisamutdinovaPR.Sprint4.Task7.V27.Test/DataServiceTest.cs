// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint4.Task7.V27
// Description: Unit-тест метода Calculate для строки 583197256891.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint4.Task7.V27.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ShouldReturn_6_ForGivenString()
        {
            // arrange
            int n = 4;
            int m = 3;
            string value = "583197256891";

            DataService ds = new DataService();

            // act
            int result = ds.Calculate(n, m, value);

            // assert
            Assert.AreEqual(6, result);
        }
    }
}