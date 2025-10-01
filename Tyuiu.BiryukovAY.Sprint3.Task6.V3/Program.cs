using System;
using Tyuiu.BiryukovAY.Sprint3.Task6.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int result = ds.GetSumTheDivisors(13, 19);
        Console.WriteLine($"Сумма делителей: {result}");

        Console.ReadKey();
    }
}