using System;

using System.Collections.Generic;

class MapInv
{
    public static Dictionary<int, List<string>> InvertMap(Dictionary<string, int> data)
    {
        Dictionary<int, List<string>> inv = new Dictionary<int, List<string>>();


        foreach (var item in data)
        {
            if (!inv.ContainsKey(item.Value))
                inv[item.Value] = new List<string>();

            inv[item.Value].Add(item.Key);
        }
        return inv;
    }

    static void Main(string[] args)
    {
        Dictionary<string, int> data = new Dictionary<string, int>
        {
            { "A", 1 }, { "B", 2 }, { "C", 1 }
        };

        Dictionary<int, List<string>> res = InvertMap(data);

        foreach (var item in res)
        {
            Console.Write(item.Key + " = [");
            
            Console.Write(string.Join(", ", item.Value));
            
            Console.WriteLine("]");
        }
    }
}

