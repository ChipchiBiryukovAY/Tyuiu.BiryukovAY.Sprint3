using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BiryukovAY.Sprint3.Task6.V3.Lib
{
    public class DataService : ISprint3Task6V3
    {
        public int GetSumTheDivisors(int start, int stop)
        {
            int Sum = 0;

            for (int x = start; x <= stop; x++)
            {
                for (int d = 9; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        Sum += d;
                    }
                }
            }

            return Sum;
        }
    }
}
