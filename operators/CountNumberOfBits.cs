using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        int max = a ^ ((a ^ b) & -(a < b ? 1 : 0));
        Console.WriteLine("Maximum: " + max);
    }
}
