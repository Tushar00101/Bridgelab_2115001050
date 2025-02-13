using System;
using System.Collections.Generic;

class ZeroSumSubarrays
{
    public static void FindSubarrays(int[] arr)
    {
        Dictionary<int, List<int>> sumMap = new Dictionary<int, List<int>>();

        int sum = 0;

        sumMap[0] = new List<int> { -1 }; 

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            if (sumMap.ContainsKey(sum))
            {
                foreach (int start in sumMap[sum])
                {
                    Console.WriteLine("Subarray found: [" + (start + 1) + ", " + i + "]");
                }
            }

            if (!sumMap.ContainsKey(sum))

                sumMap[sum] = new List<int>();

            sumMap[sum].Add(i);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter array elements:");

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        Console.WriteLine("Zero sum subarrays:");
        FindSubarrays(arr);
    }
}

