using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Enter marks for Physics:");
		double physics = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Enter marks for Chemistry:");
		double chemistry = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Enter marks for Maths:");
		double maths = Convert.ToDouble(Console.ReadLine());

		double totalMarks = physics + chemistry + maths;
		double percentage = totalMarks / 3;

		string grade;
		string remarks;

		if (percentage >= 90)
		{
			grade = "A+";
			remarks = "Excellent";
		}
		else if (percentage >= 80)
		{
			grade = "A";
			remarks = "Very Good";
		}
		else if (percentage >= 70)
		{
			grade = "B";
			remarks = "Good";
		}
		else if (percentage >= 60)
		{
			grade = "C";
			remarks = "Average";
		}
		else if (percentage >= 50)
		{
			grade = "D";
			remarks = "Pass";
		}
		else
		{
			grade = "F";
			remarks = "Fail";
		}

		Console.WriteLine("\nResults:");
		Console.WriteLine($"Average Marks: {percentage:F2}%");
		Console.WriteLine($"Grade: {grade}");
		Console.WriteLine($"Remarks: {remarks}");
	}
}
