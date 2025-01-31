using System;
class Temperature
{
    static double Celsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
    static double Fahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
    static double Input(string prompt)
    {
        Console.WriteLine(prompt);
        return double.Parse(Console.ReadLine());
    }
    static void Result(string conversionType, double originalTemp, double convertedTemp)
    {
        Console.WriteLine("Converted "+conversionType+ " temperature: "+ convertedTemp);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Temperature Converter (C ↔ F)");
        Console.WriteLine("1. F to C\n2. C to F");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            double fahrenheit = Input("Enter Fahrenheit:");
            double celsius = Celsius(fahrenheit);
            Result("Celsius", fahrenheit, celsius);
        }
        else if (choice == 2)
        {
            double celsius = Input("Enter Celsius:");
            double fahrenheit = Fahrenheit(celsius);
            Result("Fahrenheit", celsius, fahrenheit);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}
