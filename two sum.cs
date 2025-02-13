using System;
using System.Collections.Generic;

class TwoSum
{
    public static int[] FindIndices(int[] arr, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        

        for (int i = 0; i < arr.Length; i++)
        {
            int complement = target - arr[i];

            if (map.ContainsKey(complement))
                return new int[] { map[complement], i };

            map[arr[i]] = i;
        }

        return new int[] { -1, -1 };
        
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter array elements:");
        
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        Console.WriteLine("Enter target sum:");
        
        int target = int.Parse(Console.ReadLine());

        int[] result = FindIndices(arr, target);
        

        if (result[0] == -1)
            Console.WriteLine("No pair found");
        else
            Console.WriteLine("Indices: [" + result[0] + ", " + result[1] + "]");
    }
}
