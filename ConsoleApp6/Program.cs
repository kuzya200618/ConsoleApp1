using System;

class Program
{
    static void Main()
    {
        // Ввод числа
        Console.Write("Введіть ціле число: ");
        int number = int.Parse(Console.ReadLine());

        // Перевірка, чи є число парним чи непарним
        if (number % 2 == 0)
        {
            Console.WriteLine("Число є парним.");
        }
        else
        {
            Console.WriteLine("Число є непарним.");
        }
    }
}