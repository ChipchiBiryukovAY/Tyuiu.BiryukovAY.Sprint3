using System;
using Tyuiu.BiryukovAY.Sprint3.Task4.V27.Lib;
namespace Tyuiu.BiryukovAY.Sprint3.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double expected = -44.313;

            double actual = ds.Calculate(-5, 5);

            double delta = 0.001;
            Assert.AreEqual(expected, actual, delta);
        }
    }
}
