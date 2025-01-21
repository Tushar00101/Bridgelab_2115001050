using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        if ((num & (num - 1)) == 0 && num > 0)
            Console.WriteLine(num + " is a power of 2");
        else
            Console.WriteLine(num + " is not a power of 2");
    }
}
