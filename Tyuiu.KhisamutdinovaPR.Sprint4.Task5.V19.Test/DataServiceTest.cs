// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint4.Task5.V23
// Description: Тест метода Calculate на подсчёт положительных элементов.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint4.Task5.V19.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ShouldReturnCorrectPositiveCount()
        {
            // arrange
            int[,] matrix =
            {
                { -1, 0, 2, -2, 3 },
                { 1, 1, 0, -2, -1 },
                { 2, -1, 3, 0, 0 },
                { -2, 0, 0, 2, -1 },
                { 3, 1, -1, -2, 0 }
            };

            DataService ds = new DataService();

            // act
            int result = ds.Calculate(matrix);

            // assert
            Assert.AreEqual(10, result);
        }
    }
}