using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Enter a number:");
		int number = Convert.ToInt32(Console.ReadLine());

		int greatestFactor = 1;

		for (int i = number - 1; i >= 1; i--)
		{
			if (number % i == 0)
			{
				greatestFactor = i;
				break;
			}
		}

		Console.WriteLine($"The greatest factor of {number} (besides itself) is {greatestFactor}.");
	}
}
