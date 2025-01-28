using System;

class WindChill
{
    static void Main()
    {
        Console.WriteLine("Temperature in Fahrenheit:");
		
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Wind speed in miles per hour:");
		
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        if (temperature > 50 || windSpeed < 3)
        {
            Console.WriteLine("only valid for temperature <= 50°F and wind  >= 3 mph");
            return;
        }

        double windChill = CalculateWind(temperature, windSpeed);

        Console.WriteLine($"The wind chill temperature is: {windChill:F2}°F");
    }

    public static double CalculateWind(double temperature, double windSpeed)
    {
        return 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
    }
}
