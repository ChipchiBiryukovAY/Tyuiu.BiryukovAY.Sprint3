using System;
using Tyuiu.BiryukovAY.Sprint3.Task4.V27.Lib;
namespace Tyuiu.BiryukovAY.Sprint3.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        private const double Delta = 0.0001;
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(-5, 5);

            Assert.AreEqual(-44.313, result, Delta);
        }
    }
}
