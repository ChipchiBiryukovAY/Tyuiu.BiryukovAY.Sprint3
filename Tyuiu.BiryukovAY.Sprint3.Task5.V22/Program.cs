using System;
using Tyuiu.BiryukovAY.Sprint3.Task5.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();

        Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ ");
        Console.WriteLine("****************************");
        Console.WriteLine("Формула: y = ∑(j=1→3) ∑(k=1→12) (x³ * sin(k) + 2)");
        Console.WriteLine("При x = 2");
        Console.WriteLine();

        double result = dataService.GetSumSumSeries(2, 1, 3, 1, 12);

        Console.WriteLine($"Результат: {result:F3}");


        Console.ReadKey();
    }
}