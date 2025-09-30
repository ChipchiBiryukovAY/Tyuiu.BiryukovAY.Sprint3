using System;
using Tyuiu.BiryukovAY.Sprint3.Task3.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Write("Введите строку: ");
        string input = Console.ReadLine() ?? "";

        int result = ds.ConvertStringToInt(input);
        Console.WriteLine($"Результат: {result}");

        Console.ReadKey();
    }
}