using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Enter your weight (in kg):");
		double weight = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Enter your height (in cm):");
		double heightCm = Convert.ToDouble(Console.ReadLine());

		double heightM = heightCm / 100;

		double bmi = weight / (heightM * heightM);

		Console.WriteLine($"Your BMI is: {bmi:F2}");

		if (bmi < 18.5)
		{
			Console.WriteLine("You are Underweight.");
		}
		else if (bmi >= 18.5 && bmi < 24.9)
		{
			Console.WriteLine("You have Normal weight.");
		}
		else if (bmi >= 25 && bmi < 29.9)
		{
			Console.WriteLine("You are Overweight.");
		}
		else
		{
			Console.WriteLine("You are Obese.");
		}
	}
}
