using System;
class ThreeMaximum{
    static int Number(string s)
    {
        Console.WriteLine(s);
        return int.Parse(Console.ReadLine());
    }

    static int Maximum(int num1, int num2, int num3)
    {
        return Math.Max(num1, Math.Max(num2, num3));
    }
    static void Main(string[] args){

        int num1 = Number("Enter the first number:");

        int num2 = Number("Enter the second number:");
        int num3 = Number("Enter the third number:");

        int max = Maximum(num1, num2, num3);

        Console.WriteLine("The maximum number is: " + max);
    }
}