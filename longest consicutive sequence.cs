using System;
using System.Collections.Generic;

class LongSeq
{
    public static int FindLongest(int[] arr)
    {
        HashSet<int> set = new HashSet<int>(arr);

        int maxLen = 0;

        foreach (int num in set)
        {
            if (!set.Contains(num - 1)) 
            {
                int currNum = num;

                int count = 1;

                while (set.Contains(currNum + 1))
                {
                    currNum++;

                    count++;
                }

                maxLen = Math.Max(maxLen, count);
            }
        }

        return maxLen;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter array elements:");

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int longest = FindLongest(arr);

        Console.WriteLine("Longest consecutive sequence length: " + longest);
    }
}

