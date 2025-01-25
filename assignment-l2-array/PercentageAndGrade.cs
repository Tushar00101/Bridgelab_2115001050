using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of students:");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        int[,] marks = new int[numberOfStudents, 3]; // 2D array to store marks for Physics, Chemistry, Maths
        double[] percentages = new double[numberOfStudents];
        string[] grades = new string[numberOfStudents];

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"\nEntering marks for Student {i + 1}:");

            for (int j = 0; j < 3; j++)
            {
                string subject = j == 0 ? "Physics" : j == 1 ? "Chemistry" : "Maths";
                Console.WriteLine($"Enter marks for {subject}:");
                marks[i, j] = Convert.ToInt32(Console.ReadLine());

                if (marks[i, j] < 0)
                {
                    Console.WriteLine("Invalid marks. Please enter positive values.");
                    j--;
                }
            }

            // Calculate total marks and percentage
            int totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentages[i] = (totalMarks / 300.0) * 100;

            // Determine grade based on percentage
            if (percentages[i] >= 90)
                grades[i] = "A";
            else if (percentages[i] >= 80)
                grades[i] = "B";
            else if (percentages[i] >= 70)
                grades[i] = "C";
            else if (percentages[i] >= 60)
                grades[i] = "D";
            else
                grades[i] = "F";
        }

        // Display results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tPercentage\tGrade");
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"{i + 1}\t{marks[i, 0]}\t{marks[i, 1]}\t\t{marks[i, 2]}\t{percentages[i]:F2}\t\t{grades[i]}");
        }
    }
}
