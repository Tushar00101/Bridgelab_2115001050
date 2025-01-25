using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();

        // Validate input to ensure it is a valid number
        if (!long.TryParse(input, out long number) || number < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative number.");
            return;
        }

        // Convert the number to a string to handle its digits
        int[] frequency = new int[10]; // Array to store the frequency of each digit (0-9)

        foreach (char digit in input)
        {
            int currentDigit = digit - '0'; // Convert char to int
            frequency[currentDigit]++;
        }

        // Display the frequency of each digit
        Console.WriteLine("\nFrequency of each digit:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine($"Digit {i}: {frequency[i]}");
            }
        }
    }
}
