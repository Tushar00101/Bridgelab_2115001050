using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check if it is a prime number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 1)
        {
            Console.WriteLine($"{number} is not a Prime Number.");
        }
        else
        {
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{number} is a Prime Number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a Prime Number.");
            }
        }
    }
}
