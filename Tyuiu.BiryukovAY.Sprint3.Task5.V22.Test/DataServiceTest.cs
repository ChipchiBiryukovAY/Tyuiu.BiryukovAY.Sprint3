using System;
using Tyuiu.BiryukovAY.Sprint3.Task5.V22.Lib;
namespace Tyuiu.BiryukovAY.Sprint3.Task5.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double result = ds.GetSumSumSeries(1, 1, 2, 1, 3);

            Assert.IsFalse(double.IsNaN(result));
            Assert.IsFalse(double.IsInfinity(result));
        }
    }
}
