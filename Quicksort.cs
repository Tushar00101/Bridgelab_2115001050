using System;

class PriceSort
{
    public static void SortPrices(int[] prices, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(prices, left, right);
            
            SortPrices(prices, left, pivotIndex - 1);
            
            SortPrices(prices, pivotIndex + 1, right);
        }
    }

    public static int Partition(int[] prices, int left, int right)
    {
        int pivot = prices[right];
        
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (prices[j] <= pivot)
            {
                i++;
                
                int temp = prices[i];
                
                prices[i] = prices[j];
                
                prices[j] = temp;
            }
        }

        int temp2 = prices[i + 1];
        
        prices[i + 1] = prices[right];
        
        prices[right] = temp2;

        return i + 1;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of product prices:");
        
        int count = int.Parse(Console.ReadLine());
        
        int[] prices = new int[count];

        Console.WriteLine("Enter product prices:");
        
        for (int i = 0; i < count; i++)
        {
            prices[i] = int.Parse(Console.ReadLine());
        }

        SortPrices(prices, 0, count - 1);

        Console.WriteLine("Sorted product prices:");
        
        for (int i = 0; i < count; i++)
        {
            Console.Write(prices[i] + " ");
        }
    }
}
