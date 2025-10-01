using System;
using Tyuiu.BiryukovAY.Sprint3.Task7.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();

        Console.WriteLine("Табулирование функции F(x) = (cos(x) / (x + 1)) - cos(x) * 1.3 + 3x");
        Console.WriteLine("Диапазон: [-5; 5] с шагом 1");
        Console.WriteLine("==========================================");
        Console.WriteLine("    x    |   F(x)   ");
        Console.WriteLine("---------|----------");

        // Получаем массив значений
        double[] results = dataService.GetMassFunction(-5, 5);

        // Выводим таблицу
        int x = -5;
        foreach (double value in results)
        {
            Console.WriteLine($" {x,5}  | {value,8:F2}");
            x++;
        }

        Console.ReadKey();
    }
}