using System;

class Factorial
{
    static int Calculate(int number)
    {
        if (number == 0 || number == 1)
            return 1;
        return number * Calculate(number - 1);
    }

    static int Input()
    {
        Console.WriteLine("Enter a number: ");
        return int.Parse(Console.ReadLine());
    }

    static void Show(int number, int result)
    {
        Console.WriteLine("Factorial of " + number + " is: " + result);
    }

    static void Main(string[] args)
    {
        int num = Input();
        if (num < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            int factorial = Calculate(num);
            Show(num, factorial);
        }
    }
}
