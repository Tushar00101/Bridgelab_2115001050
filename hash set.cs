using System;
using System.Collections.Generic;

class PairSum
{
    public static bool HasPair(int[] arr, int target)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (int num in arr)
        {
            if (set.Contains(target - num))
            {
                Console.WriteLine("Pair found: (" + (target - num) + ", " + num + ")");
                
                return true;
            }
            set.Add(num);
        }

        Console.WriteLine("No pair found");
        
        return false;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter array elements:");
        
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        Console.WriteLine("Enter target sum:");
        
        int target = int.Parse(Console.ReadLine());

        HasPair(arr, target);
    }
}

