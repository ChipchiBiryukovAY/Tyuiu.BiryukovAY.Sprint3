using System;
using Tyuiu.BiryukovAY.Sprint3.Task3.V13.Lib;
namespace Tyuiu.BiryukovAY.Sprint3.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int result = ds.ConvertStringToInt("?sd!! 5gh. s!  ");

            Assert.AreEqual(5, result);
        }
    }
}
