using System;

class Program
{
	static void Main(string[] args)
	{
		if (args.Length != 3)
		{
			Console.WriteLine("Usage: DayOfWeek <month> <day> <year>");
			return;
		}

		int m = int.Parse(args[0]);
		int d = int.Parse(args[1]);
		int y = int.Parse(args[2]);

		int y0 = y - (14 - m) / 12;
		int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
		int m0 = m + 12 * ((14 - m) / 12) - 2;
		int d0 = (d + x + 31 * m0 / 12) % 7;

		Console.WriteLine(d0);
	}
}

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        double first = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double second = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the operator (+, -, *, /):");
        string op = Console.ReadLine();

        switch (op)
        {
            case "+":
                Console.WriteLine($"Result: {first + second}");
                break;
            case "-":
                Console.WriteLine($"Result: {first - second}");
                break;
            case "*":
                Console.WriteLine($"Result: {first * second}");
                break;
            case "/":
                if (second != 0)
                {
                    Console.WriteLine($"Result: {first / second}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid Operator.");
                break;
        }
    }
}
