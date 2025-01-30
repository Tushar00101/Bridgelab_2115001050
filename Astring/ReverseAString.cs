using System;

class ReverseAString
{    static void ReverseString(string str, out string reverse)
    {
        reverse = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reverse += str[i] + "";
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        string reverse;
        ReverseString(str, out reverse);
        Console.WriteLine("String you entered: " + str + " And reversed string: " + reverse);
    }
}