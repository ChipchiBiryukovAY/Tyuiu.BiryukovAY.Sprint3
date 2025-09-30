using System;
using Tyuiu.BiryukovAY.Sprint3.Task4.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        double result = ds.Calculate(-5, 5);
        Console.WriteLine($"Сумма: {result:F6}");

        Console.ReadKey();
    }
}