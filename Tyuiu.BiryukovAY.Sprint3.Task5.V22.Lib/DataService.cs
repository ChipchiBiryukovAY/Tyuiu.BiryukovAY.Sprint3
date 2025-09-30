using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BiryukovAY.Sprint3.Task5.V22.Lib
{
    public class DataService : ISprint3Task5V22
    {
        public double GetSumSumSeries(int x, int startj, int startk, int stopj, int stopk)
        {
            double sumSeries = 0.0;
            double xCubed = Math.Pow(x, 3); 

            for (int j = startj; j <= stopj; j++)
            {
                for (int k = startk; k <= stopk; k++)
                {
                    sumSeries += xCubed * Math.Sin(k) + 2;
                }
            }

            return Math.Round(sumSeries, 3);
        }
    }
}
