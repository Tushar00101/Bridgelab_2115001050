using System;
class Calculator
{
    static double Add(double a, double b)
    {
        return a + b;
    }
    static double Subtract(double a, double b)
    {
        return a - b;
    }
    static double Multiply(double a, double b)
    {
        return a * b;
    }
    static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero.");

            return 0;
        }
        return a / b;
    }
    static double Input(string prompt)
    {
        Console.WriteLine(prompt);

        return double.Parse(Console.ReadLine());
    }
    static void Result(string operation, double result)
    {
        Console.WriteLine("The result of "+ operation+" is: {result}");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Basic Calculator");

        Console.WriteLine("Choose an operation:\n1. Add\n2. Subtract\n3. Multiply\n4. Divide");

        int choice = int.Parse(Console.ReadLine());

        double num1 = Input("Enter the first number:");

        double num2 = Input("Enter the second number:");

        double result = 0;

        string operation = "";

        switch (choice)
        {
            case 1:
                result = Add(num1, num2);
                operation = "addition";
                break;
            case 2:
                result = Subtract(num1, num2);
                operation = "subtraction";
                break;
            case 3:
                result = Multiply(num1, num2);
                operation = "multiplication";
                break;
            case 4:
                result = Divide(num1, num2);
                operation = "division";
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        Result(operation, result);
    }
}
