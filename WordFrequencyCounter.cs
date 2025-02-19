using System;

using System.IO;

using System.Collections.Generic;

class WordFreq
{
    public static Dictionary<string, int> Count(string file)
    {
        string text = File.ReadAllText(file).ToLower();

        char[] sep = { ' ', ',', '.', '!', '?', ';', ':', '\n', '\r' };

        string[] words = text.Split(sep, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> freq = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (freq.ContainsKey(word))

                freq[word]++;
            else

                freq[word] = 1;
        }
        return freq;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter file path:");

        string path = Console.ReadLine();
        
        if (File.Exists(path))
        {
            Dictionary<string, int> res = Count(path);

            foreach (var item in res)
                Console.WriteLine(item.Key + ": " + item.Value);
        }
        else
            Console.WriteLine("File not found.");
    }
}

