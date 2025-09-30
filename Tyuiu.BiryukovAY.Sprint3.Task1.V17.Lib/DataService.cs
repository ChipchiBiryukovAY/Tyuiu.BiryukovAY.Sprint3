using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BiryukovAY.Sprint3.Task1.V17.Lib
{
    public class DataService : ISprint3Task1V17
    {
        public double GetMultiplySeries(int x, int start, int stop)
        {
            double p = 1.0;
            int k = start;

            while (k <= stop)
            {
                p *= Math.Pow(-2.0 / Math.Cos(x), k);
                k++;
            }

            return Math.Round(p, 3);
        }
    }
}
