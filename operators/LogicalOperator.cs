using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first angle of the triangle: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second angle of the triangle: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter the third angle of the triangle: ");
        int c = int.Parse(Console.ReadLine());
        if (a > 0 && b > 0 && c > 0 && (a + b + c == 180))
            Console.WriteLine("The angles form a valid triangle.");
        else
            Console.WriteLine("The angles do not form a valid triangle.");
    }
}
