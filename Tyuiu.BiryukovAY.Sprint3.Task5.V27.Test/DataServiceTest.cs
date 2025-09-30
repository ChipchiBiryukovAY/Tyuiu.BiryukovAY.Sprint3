using System;
using Tyuiu.BiryukovAY.Sprint3.Task5.V27.Lib;
namespace Tyuiu.BiryukovAY.Sprint3.Task5.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(-5, 5);

            Assert.IsFalse(double.IsNaN(result));
            Assert.IsFalse(double.IsInfinity(result));
        }
    }
}
 