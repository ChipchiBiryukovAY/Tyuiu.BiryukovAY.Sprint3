using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BiryukovAY.Sprint3.Task4.V27.Lib
{
    public class DataService : ISprint3Task4V27
    {
        public double Calculate(int start, int stop)
        {
            double sum = 0.0;

            for (int x = start; x <= stop; x++)
            {
                if (x == 0) continue;

                double denominator = Math.Cos(x) + Math.Sin(x);
                if (Math.Abs(denominator) < 0.0000001) continue;

                double y = x / denominator;
                sum += y;
            }

            return Math.Round(sum, 3);
        }
    }
}
