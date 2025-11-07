// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint4.Task4.V23
// Description: Unit-тест для проверки метода Calculate.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint4.Task4.V14.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ShouldReplaceOddNumbersWithZero()
        {
            // arrange
            int[,] input =
            {
                { 1, 3, 7, 7, 6 },
                { 4, 2, 6, 3, 3 },
                { 4, 5, 1, 4, 6 },
                { 7, 5, 2, 7, 7 },
                { 2, 4, 4, 4, 7 }
            };

            int[,] expected =
            {
                { 0, 0, 0, 0, 6 },
                { 4, 2, 6, 0, 0 },
                { 4, 0, 0, 4, 6 },
                { 0, 0, 2, 0, 0 },
                { 2, 4, 4, 4, 0 }
            };

            DataService ds = new DataService();

            // act
            int[,] actual = ds.Calculate(input);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}