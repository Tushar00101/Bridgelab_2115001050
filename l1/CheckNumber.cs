using System;

class Spring
{
    static void Main()
    {
        Console.WriteLine("Enter the month (1 for January, 2 for February, ..., 12 for December):");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the day:");
        int day = Convert.ToInt32(Console.ReadLine());

        bool isSpring = IsSpringSeason(month, day);

        if (isSpring)
        {
            Console.WriteLine("It's a Spring Season.");
        }
        else
        {
            Console.WriteLine("Not a Spring Season.");
        }
    }

    static bool IsSpringSeason(int month, int day)
    {
        if ((month == 3 && day >= 20) || (month > 3 && month < 6) || (month == 6 && day <= 20))
        {
            return true;
        }
        return false;
    }
}
