using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Enter the age of Amar:");
		int amarAge = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the age of Akbar:");
		int akbarAge = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the age of Anthony:");
		int anthonyAge = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the height of Amar (in cm):");
		double amarHeight = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Enter the height of Akbar (in cm):");
		double akbarHeight = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Enter the height of Anthony (in cm):");
		double anthonyHeight = Convert.ToDouble(Console.ReadLine());

		int youngestAge = Math.Min(amarAge, Math.Min(akbarAge, anthonyAge));
		string youngestFriend = (youngestAge == amarAge) ? "Amar" : (youngestAge == akbarAge) ? "Akbar" : "Anthony";

		double tallestHeight = Math.Max(amarHeight, Math.Max(akbarHeight, anthonyHeight));
		string tallestFriend = (tallestHeight == amarHeight) ? "Amar" : (tallestHeight == akbarHeight) ? "Akbar" : "Anthony";

		Console.WriteLine($"The youngest friend is {youngestFriend} with age {youngestAge}.");
		Console.WriteLine($"The tallest friend is {tallestFriend} with height {tallestHeight} cm.");
	}
}
