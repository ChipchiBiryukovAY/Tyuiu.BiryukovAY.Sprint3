using System;
using Tyuiu.BiryukovAY.Sprint3.Task6.V3.Lib;
namespace Tyuiu.BiryukovAY.Sprint3.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int start = 13;
            int stop = 19;
            int result = ds.GetSumTheDivisors(start, stop);

            int wait = 121;
            Assert.AreEqual(wait, result);
        }
    }
}
