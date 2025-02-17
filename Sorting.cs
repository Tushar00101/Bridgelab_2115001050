using System;

class SortComp
{
    public static void BubSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    
                    arr[j] = arr[j + 1];
                    
                    arr[j + 1] = temp;
                }
            }
        }
    }

    public static void MrgSort(int[] arr, int left, int right)
    {
        if (left >= right) return;
        int mid = left + (right - left) / 2;
        MrgSort(arr, left, mid);
        
        MrgSort(arr, mid + 1, right);
        
        Merge(arr, left, mid, right);
    }

    private static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];
        
        int i = left, j = mid + 1, k = 0;

        while (i <= mid && j <= right)
            temp[k++] = arr[i] < arr[j] ? arr[i++] : arr[j++];

        while (i <= mid) temp[k++] = arr[i++];
        
        while (j <= right) temp[k++] = arr[j++];
        
        for (i = left, k = 0; i <= right; i++, k++)
            arr[i] = temp[k];
    }

    public static void QckSort(int[] arr, int left, int right)
    {
        if (left >= right) return;
        
        int pivot = Partition(arr, left, right);
        
        QckSort(arr, left, pivot - 1);
        
        QckSort(arr, pivot + 1, right);
    }

    private static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right], i = left - 1;
        for (int j = left; j < right; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }
        (arr[i + 1], arr[right]) = (arr[right], arr[i + 1]);
        
        return i + 1;
    }

    static void Main(string[] args)
    {
        int n = 10000;
        
        int[] arr1 = new int[n], arr2 = new int[n], arr3 = new int[n];
        
        Random rnd = new Random();
        
        for (int i = 0; i < n; i++)
        {
            int val = rnd.Next(n);
            
            arr1[i] = arr2[i] = arr3[i] = val;
        }

        var sw = System.Diagnostics.Stopwatch.StartNew();

        sw.Restart();
        
        BubSort(arr1);
        
        sw.Stop();
        
        Console.WriteLine("Bubble Sort: " + sw.ElapsedMilliseconds + " ms");

        sw.Restart();
        
        MrgSort(arr2, 0, n - 1);
        
        sw.Stop();
        
        Console.WriteLine("Merge Sort: " + sw.ElapsedMilliseconds + " ms");

        sw.Restart();
        
        QckSort(arr3, 0, n - 1);
        
        sw.Stop();
        
        Console.WriteLine("Quick Sort: " + sw.ElapsedMilliseconds + " ms");
    }
}
