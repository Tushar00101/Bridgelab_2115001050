using System;

class Trigonomety
{
    static void Main()
    {
        Console.WriteLine("Angle in degrees:");
		
        double degrees = Convert.ToDouble(Console.ReadLine());

        double[] Values = CalculateTrigonometricFunctions(degrees);

        Console.WriteLine($"Sine of {angleInDegrees}° is: {Values[0]:F4}");
		
        Console.WriteLine($"Cosine of {angleInDegrees}° is: {Values[1]:F4}");
		
        Console.WriteLine($"Tangent of {angleInDegrees}° is: {Values[2]:F4}");
    }

    public static double[] CalculateTrigonometricFunctions(double angleInDegrees)
    {
        
        double angleInRadians = angleInDegrees * (Math.PI / 180);

        
        double sine = Math.Sin(angleInRadians);
		
        double cosine = Math.Cos(angleInRadians);
		
        double tangent = Math.Tan(angleInRadians);

        return new double[] { sine, cosine, tangent };
    }
}
