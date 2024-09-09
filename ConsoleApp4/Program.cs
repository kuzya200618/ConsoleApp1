using System;

class Program
{
    static void Main()
    {
        // Ввод трех чисел
        Console.Write("Введіть перше число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Введіть третє число: ");
        int c = int.Parse(Console.ReadLine());

        // Знаходимо максимальне та мінімальне значення
        int max = Math.Max(a, Math.Max(b, c));
        int min = Math.Min(a, Math.Min(b, c));

        // Вивід результатів
        Console.WriteLine($"Max: {max}, Min: {min}");
    }
}