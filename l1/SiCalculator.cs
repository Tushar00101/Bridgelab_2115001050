using System;

class SiCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter the Principal :");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Rate of Interest:");
        double rate = Convert.ToDouble(Console.ReadLine());
		
        Console.WriteLine("Enter Time (in years):");
        double time = Convert.ToDouble(Console.ReadLine());
        double interest = CalculateSi(principal, rate, time);

        Console.WriteLine($"The Simple Interest is {interest} for Principal {principal}, Rate of Interest {rate} and Time {time}");
    }

    public static double CalculateSi(double principal, double rate, double time)
    {
        return principal * rate * time / 100;
    }
}
