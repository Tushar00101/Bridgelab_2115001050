using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of persons:");
        int numberOfPersons = Convert.ToInt32(Console.ReadLine());

        double[] weights = new double[numberOfPersons];
        double[] heights = new double[numberOfPersons];
        double[] bmis = new double[numberOfPersons];
        string[] statuses = new string[numberOfPersons];

        // Input weight and height
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"Enter weight (in kg) for person {i + 1}:");
            weights[i] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Enter height (in meters) for person {i + 1}:");
            heights[i] = Convert.ToDouble(Console.ReadLine());

            if (weights[i] <= 0 || heights[i] <= 0)
            {
                Console.WriteLine("Invalid input. Please enter positive values.");
                i--;
                continue;
            }
        }

        // Calculate BMI and determine weight status
        for (int i = 0; i < numberOfPersons; i++)
        {
            bmis[i] = weights[i] / (heights[i] * heights[i]);

            if (bmis[i] < 18.5)
                statuses[i] = "Underweight";
            else if (bmis[i] >= 18.5 && bmis[i] < 24.9)
                statuses[i] = "Normal weight";
            else if (bmis[i] >= 25 && bmis[i] < 29.9)
                statuses[i] = "Overweight";
            else
                statuses[i] = "Obese";
        }

        // Display results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Person\tHeight (m)\tWeight (kg)\tBMI\t\tStatus");
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"{i + 1}\t{heights[i]:F2}\t\t{weights[i]:F2}\t\t{bmis[i]:F2}\t\t{statuses[i]}");
        }
    }
}
