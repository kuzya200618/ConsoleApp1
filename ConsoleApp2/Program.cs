using System;

partial class Program
{
    static void Main()
    {
        // Ввод действительного числа
        Console.Write("Введите действительное число: ");
        double number = double.Parse(Console.ReadLine());

        // Преобразование числа в строку с двумя знаками после запятой
        string numberString = number.ToString("F2");

        // Получение дробной части числа
        int decimalPart = int.Parse(numberString.Split('.')[1]);

        // Извлечение двух первых знаков после запятой
        int firstDigit = decimalPart / 10; // первый знак после запятой
        int secondDigit = decimalPart % 10; // второй знак после запятой

        // Вычисление суммы двух знаков
        int sum = firstDigit + secondDigit;

        // Вывод результата
        Console.WriteLine($"{firstDigit} + {secondDigit} = {sum}");
    }
}
