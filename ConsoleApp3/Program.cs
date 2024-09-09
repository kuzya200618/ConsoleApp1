using System;

class Program
{
    static void Main()
    {
        // Ввод времени в часах
        Console.Write("Введите целое число, представляющее время дня (часы от 0 до 23): ");
        int h = int.Parse(Console.ReadLine());

        // Проверка введенного значения и вывод соответствующего приветствия
        if (h >= 0 && h < 6)
        {
            Console.WriteLine("Доброї ночі!");
        }
        else if (h >= 6 && h < 12)
        {
            Console.WriteLine("Доброго ранку!");
        }
        else if (h >= 12 && h < 18)
        {
            Console.WriteLine("Добрий день!");
        }
        else if (h >= 18 && h < 24)
        {
            Console.WriteLine("Добрий вечір!");
        }
        else
        {
            Console.WriteLine("Введене значення не є допустимим часом. Будь ласка, введіть число від 0 до 23.");
        }
    }
}
