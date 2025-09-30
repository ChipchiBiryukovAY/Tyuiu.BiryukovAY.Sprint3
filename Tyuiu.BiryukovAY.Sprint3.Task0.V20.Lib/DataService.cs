using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BiryukovAY.Sprint3.Task0.V20.Lib
{
    public class DataService : ISprint3Task0V20
    {
        public double GetMultiplySeries(int x, int start, int stop)
        {
            double p = 1.0;
            for (int k = start; k <= stop; k++)
            {
                p *= Math.Cos(x) + Math.Pow(k / 8.0, 3);
            }
            return Math.Round(p, 3);
        }
    }
}
