using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Enter a number:");
		int number = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine($"The multiples of {number} below 100 are:");

		for (int i = 100; i >= 1; i--)
		{
			if (i % number == 0)
			{
				Console.WriteLine(i);
			}
		}
	}
}
