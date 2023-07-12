using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите три числа:");

        // Чтение трех чисел с консоли
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());

        // Переменная для максимального числа
        int maxNumber = number1;

        // Проверка, является ли number2 максимальным числом
        if (number2 > maxNumber)
        {
            maxNumber = number2;
        }

        // Проверка, является ли number3 максимальным числом
        if (number3 > maxNumber)
        {
            maxNumber = number3;
        }

        // Вывод максимального числа
        Console.WriteLine($"Максимальное число: {maxNumber}");
    }
}