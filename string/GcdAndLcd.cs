using System;

class GcdAndLcd
{
        static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int LCM(int a, int b)
    {
        return Math.Abs(a * b) / GCD(a, b);
    }

    static (int, int) Input()
    {
        Console.WriteLine("Enter the first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = int.Parse(Console.ReadLine());

        return (num1, num2);
    }    static void Display(int num1, int num2, int gcd, int lcm)
    {
        Console.WriteLine($"GCD of {num1} and {num2} is: " + gcd);
        Console.WriteLine($"LCM of {num1} and {num2} is: " + lcm);
    }

    static void Main(string[] args)
    {
        var (num1, num2) = Input();

        int gcd = GCD(num1, num2);

        int lcm = LCM(num1, num2);

        Display(num1, num2, gcd, lcm);
    }
}
