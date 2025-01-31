using System;

class DateComparison
{
    static void Main(string[] args){
        Console.WriteLine("Enter the first date (yyyy-MM-dd):");

        DateTime first = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second date (yyyy-MM-dd):");
        DateTime second = DateTime.Parse(Console.ReadLine());

        int result = first.CompareTo(second);

        if (result < 0)
        {
            Console.WriteLine("The first date is before the second date.");
        }
        else if (result > 0)
        {
            Console.WriteLine("The first date is after the second date.");
        }
        else
        {
            Console.WriteLine("Both dates are the same.");
        }
    }
}
