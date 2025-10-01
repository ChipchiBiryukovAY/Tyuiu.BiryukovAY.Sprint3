using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BiryukovAY.Sprint3.Task7.V27.Lib
{
    public class DataService : ISprint3Task7V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] resultArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == -1) 
                {
                    resultArray[count] = 0;
                }
                else
                {
                    double cosX = Math.Cos(x);
                    double part1 = cosX / (x + 1);
                    double part2 = cosX * 1.3;
                    double part3 = 3 * x;
                    double result = part1 - part2 + part3;
                    resultArray[count] = Math.Round(result, 2);
                }
                count++;
            }

            return resultArray;
        }
    }
}
