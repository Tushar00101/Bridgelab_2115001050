using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the base: ");
        double baseNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the exponent: ");
        double exponent = double.Parse(Console.ReadLine());

        double result = Math.Pow(baseNumber, exponent);

        Console.WriteLine("Result: " + result);
    }
}
