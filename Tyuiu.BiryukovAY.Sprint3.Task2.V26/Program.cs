using System;
using Tyuiu.BiryukovAY.Sprint3.Task2.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Write("Введите x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double result = ds.GetMultiplySeries(x, 1, 17);
        Console.WriteLine($"Результат: {result:F3}");

        Console.ReadKey();
    }
}