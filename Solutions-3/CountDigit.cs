using System;

class Program
{
    static void Main()
    {
        int number, count = 0;
        Console.WriteLine("Enter a number:");
        number = Convert.ToInt32(Console.ReadLine());

        while (number != 0)
        {
            number /= 10;
            count++;
        }

        Console.WriteLine($"The number of digits is: {count}");
    }
}
