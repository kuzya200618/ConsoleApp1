using System;

class Program
{
    static void Main()
    {
        // Введення температури в градусах Цельсія
        Console.Write("Введіть температуру в градусах Цельсія: ");
        string input = Console.ReadLine();

        // Перетворення введеного значення в число
        double celsius;
        if (double.TryParse(input, out celsius))
        {
            // Перетворення температури в градуси Фаренгейта
            double fahrenheit = CelsiusToFahrenheit(celsius);

            // Виведення результату
            Console.WriteLine($"{celsius} градусів Цельсія дорівнює {fahrenheit} градусів Фаренгейта.");
        }
        else
        {
            Console.WriteLine("Будь ласка, введіть правильне число.");
        }
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }
}