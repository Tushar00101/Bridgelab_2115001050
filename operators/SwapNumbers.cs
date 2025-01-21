using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
            Console.WriteLine(num + " is Even");
        else
            Console.WriteLine(num + " is Odd");
    }
}
