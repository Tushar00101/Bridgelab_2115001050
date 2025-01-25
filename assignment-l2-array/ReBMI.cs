using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of persons:");
        int numberOfPersons = Convert.ToInt32(Console.ReadLine());

        double[][] personData = new double[numberOfPersons][];
        string[] weightStatus = new string[numberOfPersons];

        for (int i = 0; i < numberOfPersons; i++)
        {
            personData[i] = new double[3]; // Initialize for weight, height, and BMI

            Console.WriteLine($"Enter weight (in kg) for person {i + 1}:");
            personData[i][0] = Convert.ToDouble(Console.ReadLine());
            if (personData[i][0] <= 0)
            {
                Console.WriteLine("Invalid weight. Please enter a positive value.");
                i--;
                continue;
            }

            Console.WriteLine($"Enter height (in meters) for person {i + 1}:");
            personData[i][1] = Convert.ToDouble(Console.ReadLine());
            if (personData[i][1] <= 0)
            {
                Console.WriteLine("Invalid height. Please enter a positive value.");
                i--;
                continue;
            }

            // Calculate BMI and store it in the 2D array
            personData[i][2] = personData[i][0] / (personData[i][1] * personData[i][1]);

            // Determine weight status
            if (personData[i][2] < 18.5)
                weightStatus[i] = "Underweight";
            else if (personData[i][2] >= 18.5 && personData[i][2] < 24.9)
                weightStatus[i] = "Normal weight";
            else if (personData[i][2] >= 25 && personData[i][2] < 29.9)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obese";
        }

        // Display results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Person\tHeight (m)\tWeight (kg)\tBMI\t\tStatus");
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"{i + 1}\t{personData[i][1]:F2}\t\t{personData[i][0]:F2}\t\t{personData[i][2]:F2}\t\t{weightStatus[i]}");
        }
    }
}
