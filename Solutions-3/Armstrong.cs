using System;

class Program
{
    static void Main()
    {
        int number, originalNumber, remainder, sum = 0;
        Console.WriteLine("Enter a number:");
        number = Convert.ToInt32(Console.ReadLine());
        originalNumber = number;

        while (originalNumber != 0)
        {
            remainder = originalNumber % 10;
            sum += remainder * remainder * remainder;
            originalNumber /= 10;
        }

        if (number == sum)
        {
            Console.WriteLine($"{number} is an Armstrong number.");
        }
        else
        {
            Console.WriteLine($"{number} is not an Armstrong number.");
        }
    }
}
