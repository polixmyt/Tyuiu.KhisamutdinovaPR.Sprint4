// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint4.Task3.V23
// Description: Unit-тест метода Calculate — подсчёт чётных элементов в одномерном массиве.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint4.Task3.V23.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ShouldReturn13_ForGivenArray()
        {
            // arrange
            int[] array =
            {
                7, 5, 5, 6, 7,
                8, 7, 8, 4, 3,
                5, 6, 7, 8, 3,
                4, 2, 3, 6, 4,
                5, 2, 4, 2, 3
            };

            DataService ds = new DataService();

            // act
            int result = ds.Calculate(array);

            // assert
            Assert.AreEqual(13, result);
        }
    }
}