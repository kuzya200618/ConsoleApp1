using System;

class Program
{
    static void Main()
    {
        // Ввод длины и ширины прямоугольника
        Console.Write("Введіть довжину прямокутника: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Введіть ширину прямокутника: ");
        double width = double.Parse(Console.ReadLine());

        // Вычисление площади прямоугольника
        double area = length * width;

        // Вывод площади прямоугольника
        Console.WriteLine($"Площа прямокутника: {area}");
    }
}
