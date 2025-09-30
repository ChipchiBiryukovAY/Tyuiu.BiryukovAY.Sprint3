using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BiryukovAY.Sprint3.Task2.V26.Lib
{
    public class DataService : ISprint3Task2V26
    {
        public double GetMultiplySeries(double x, int start, int stop)
        {
            double p = 1.0;
            int i = start;

            do
            {
                double term = (x * x * x * i) + 2;
                p *= term;
                i++;
            }
            while (i <= stop);

            return Math.Round(p, 3);
        }
    }
}
