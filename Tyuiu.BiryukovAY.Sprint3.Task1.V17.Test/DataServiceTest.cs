using System;
using Tyuiu.BiryukovAY.Sprint3.Task1.V17.Lib;
namespace Tyuiu.BiryukovAY.Sprint3.Task1.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        private const double Delta = 0.001;
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double result = ds.GetMultiplySeries(1, 1, 4);

            Assert.IsFalse(double.IsNaN(result));
            Assert.IsFalse(double.IsInfinity(result));
        }
    }
}
