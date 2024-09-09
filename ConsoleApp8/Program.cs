using System;

class Program
{
    static void Main()
    {
        // Введення значення n
        Console.Write("Введіть число n: ");
        string input = Console.ReadLine();

        // Перетворення введеного значення в число
        int n;
        if (int.TryParse(input, out n) && n > 0)
        {
            // Обчислення суми перших n натуральних чисел
            int sum = n * (n + 1) / 2;

            // Виведення результату
            Console.WriteLine($"Сума перших {n} натуральних чисел дорівнює {sum}.");
        }
        else
        {
            Console.WriteLine("Будь ласка, введіть правильне позитивне число.");
        }
    }
}