using System;
using System.Collections.Generic;

class SlideMax
{
    public static int[] FindMax(int[] arr, int k)
    {
        if (arr.Length == 0 || k == 0) return new int[0];


        List<int> res = new List<int>();
        
        LinkedList<int> dq = new LinkedList<int>();

        for (int i = 0; i < arr.Length; i++)
        {

            
            if (dq.Count > 0 && dq.First.Value <= i - k)
            
                dq.RemoveFirst();


            while (dq.Count > 0 && arr[dq.Last.Value] < arr[i])
                dq.RemoveLast();


            dq.AddLast(i);


            if (i >= k - 1)
                res.Add(arr[dq.First.Value]);
        }

        return res.ToArray();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter array elements:");
        
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        
        Console.WriteLine("Enter window size:");
        
        int k = int.Parse(Console.ReadLine());
        

        int[] output = FindMax(arr, k);
        
        Console.WriteLine("Sliding Window Maximum:");
        
        Console.WriteLine(string.Join(" ", output));
    }
}
