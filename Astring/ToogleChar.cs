using System;

class RemoveChar
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the String: ");
        string str = Console.ReadLine();

        Console.WriteLine("Enter the Character to Remove: ");
        char charToRemove = Console.ReadLine()[0];
        
        string result = Remove(str, charToRemove);
        Console.WriteLine("Modified String: " + result);
    }

    static string Remove(string str, char charToRemove)
    {
        char[] ch = str.ToCharArray();
        string result = "";
        for (int i = 0; i < ch.Length; i++)
        {
            if (ch[i] != charToRemove)
            {
                result += ch[i];
            }
        }
        return result;
    }
}