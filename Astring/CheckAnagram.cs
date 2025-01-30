using System;

class CheckAnagram{

    public static bool isAnagram(string input1, string input2)
    {

        if (input1.Length != input2.Length)
        {
            return false;
        }

        int[] chars1 = new int[255];
        int[] chars2 = new int[255];
        for (int i = 0; i < input2.Length;i++)
        {
            chars1[input1[i]]++;
            chars2[input2[i]]++;
        }

        for (int i = 0; i < chars1.Length; i++)
        {
            if (chars1[i] != chars2[i])
            {
                return false;
            }
        }

        return true;

    }

    static void Main(string[] args){

        Console.Write("Enter a string one: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter a string two: ");
        string input2 = Console.ReadLine();

        if (isAnagram(input1, input2)) {
            Console.WriteLine("The given two strings are anagram");
        }else{
            Console.WriteLine("The given two strings are not anagram");
        }
    }
}