using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int count = 0;
        while (num > 0)
        {
            count += (num & 1);
            num >>= 1;
        }
        Console.WriteLine("Number of 1 bits: " + count);
    }
}
