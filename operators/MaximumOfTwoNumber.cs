using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first boolean value (true/false): ");
        bool x = bool.Parse(Console.ReadLine());
        Console.Write("Enter second boolean value (true/false): ");
        bool y = bool.Parse(Console.ReadLine());
        Console.WriteLine("Logical AND: " + (x && y));
        Console.WriteLine("Logical OR: " + (x || y));
        Console.WriteLine("Logical NOT of first: " + (!x));
    }
}
