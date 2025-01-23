using System;

class Program
{
	static void Main()
	{
		int number, sum = 0;
		Console.WriteLine("Enter a number:");
		number = Convert.ToInt32(Console.ReadLine());

		for (int i = 1; i < number; i++)
		{
			if (number % i == 0)
			{
				sum += i;
			}
		}

		if (sum > number)
		{
			Console.WriteLine($"{number} is an Abundant Number.");
		}
		else
		{
			Console.WriteLine($"{number} is not an Abundant Number.");
		}
	}
}
