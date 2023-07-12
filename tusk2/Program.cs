using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        if (number1 > number2)
        {
            Console.WriteLine($"{number1} больше, чем {number2}.");
            Console.WriteLine($"{number2} меньше, чем {number1}.");
        }
        else if (number1 < number2)
        {
            Console.WriteLine($"{number2} больше, чем {number1}.");
            Console.WriteLine($"{number1} меньше, чем {number2}.");
        }
        else
        {
            Console.WriteLine("Числа равны.");
        }
    }
}