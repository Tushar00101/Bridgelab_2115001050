using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Enter a number:");
		int number = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine($"The factors of {number} are:");

		for (int i = 1; i < number; i++)
		{
			if (number % i == 0)
			{
				Console.WriteLine(i);
			}
		}
	}
}
