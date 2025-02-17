using System;

class SearchComp
{
    public static int LinSearch(int[] arr, int tgt)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == tgt) return i;
        }
        return -1;
    }

    public static int BinSearch(int[] arr, int tgt)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            
            if (arr[mid] == tgt) return mid;
            
            if (arr[mid] < tgt) left = mid + 1;
            else right = mid - 1;
        }
        return -1;
    }

    static void Main(string[] args)
    {
        int n = 1000000; 
        
        int[] arr = new int[n];
        
        for (int i = 0; i < n; i++) arr[i] = i; 

        int tgt = n - 1;

        var sw = System.Diagnostics.Stopwatch.StartNew();
        
        LinSearch(arr, tgt);
        
        sw.Stop();
        
        Console.WriteLine("Linear Search: " + sw.ElapsedMilliseconds + " ms");

        Array.Sort(arr);
        sw.Restart();
        
        BinSearch(arr, tgt);
        
        sw.Stop();
        
        Console.WriteLine("Binary Search: " + sw.ElapsedMilliseconds + " ms");
    }
}
