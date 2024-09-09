using System;

partial class Program
{
    static void Main()
    {
        // Ввод первого числа
        Console.Write("Введите первое число (день): ");
        int number1 = int.Parse(Console.ReadLine());

        // Ввод второго числа
        Console.Write("Введите второе число (месяц): ");
        int number2 = int.Parse(Console.ReadLine());

        // Проверка, может ли number1 быть днем
        bool isValidDay = number1 >= 1 && number1 <= 31;

        // Проверка, может ли number2 быть месяцем
        bool isValidMonth = number2 >= 1 && number2 <= 12;

        // Вывод результата проверки
        if (isValidDay && isValidMonth)
        {
            Console.WriteLine("Числа могут быть днем и месяцем.");
        }
        else
        {
            Console.WriteLine("Числа не могут быть днем и месяцем.");
        }
    }
}