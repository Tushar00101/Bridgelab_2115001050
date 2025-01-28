using System;

class Spring
{
    static void Main()
    {
        Console.WriteLine("Enter the month: ");
		
        int month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the day: ");
		
        int day = Convert.ToInt32(Console.ReadLine());

        if (IsCorrect(month, day))
        {
            Console.WriteLine("It's a Spring Season.");
        }
        else
        {
            Console.WriteLine("Not a Spring Season.");
        }
    }

    static bool IsCorrect(int month, int day)
    {
        if ((month == 3 && day >= 20) || (month > 3 && month < 6) || (month == 6 && day <= 20))
        {
            return true;
        }
        return false;
    }
}
