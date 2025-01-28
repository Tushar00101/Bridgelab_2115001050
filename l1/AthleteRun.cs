using System;

class AthleteRun
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the first side in meters:");
		
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of the second side in meters:");
		
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of the third side in meters:");
		
        double side3 = Convert.ToDouble(Console.ReadLine());

        double perimeter = CalculatePerimeter(side1, side2, side3);

//5 km in meter is 5000m
        double distanceToRun = 5000;
        double rounds = CalculateRounds(distanceToRun, perimeter);

        Console.WriteLine($"For5 km run, the athlete needs to complete {Math.Ceiling(rounds)} rounds.");
    }

    static double CalculatePerimeter(double side1, double side2, double side3)
    {
        return side1 + side2 + side3;
    }

    static double CalculateRounds(double distance, double perimeter)
    {
        return distance / perimeter;
    }
}
