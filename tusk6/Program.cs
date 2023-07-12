using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Да, число чётное.");
        }
        else
        {
            Console.WriteLine("Нет, число нечётное.");
        }
    }
}
