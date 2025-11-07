// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint4.Task6.V7
// Description: Unit-тест метода Calculate.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhisamutdinovaPR.Sprint4.Task6.V7.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ShouldReturn_4_WhenStringsLongerThan8()
        {
            // arrange
            string[] array = new string[]
            {
                "Математика",
                "Физика",
                "Химия",
                "Биология",
                "География",
                "История",
                "Экономика"
            };

            DataService ds = new DataService();

            // act
            int result = ds.Calculate(array);

            // assert
            Assert.AreEqual(4, result); // "Математика", "Биология", "География", "Экономика"
        }
    }
}