using System;
using Tyuiu.BiryukovAY.Sprint3.Task2.V26.Lib;
namespace Tyuiu.BiryukovAY.Sprint3.Task2.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        private const double Delta = 0.001;
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double result = ds.GetMultiplySeries(0.25, 1, 17);

            Assert.IsFalse(double.IsNaN(result));
            Assert.IsFalse(double.IsInfinity(result));
        }
    }
}
