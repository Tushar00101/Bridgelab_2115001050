using System;

class PriceSort
{
    public static void SortPrices(int[] prices, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            
            SortPrices(prices, left, mid);
            
            SortPrices(prices, mid + 1, right);
            
            Merge(prices, left, mid, right);
        }
    }

    public static void Merge(int[] prices, int left, int mid, int right)
    {
        int n1 = mid - left + 1;

        int n2 = right - mid;

        int[] leftArr = new int[n1];

        int[] rightArr = new int[n2];

        for (int i = 0; i < n1; i++)
            leftArr[i] = prices[left + i];
        for (int j = 0; j < n2; j++)
            rightArr[j] = prices[mid + 1 + j];

        int x = 0, y = 0, k = left;

        while (x < n1 && y < n2)
        {
            if (leftArr[x] <= rightArr[y])
            {
                prices[k] = leftArr[x];
                x++;
            }
            else
            {
                prices[k] = rightArr[y];
                y++;
            }
            k++;
        }

        while (x < n1)
        {
            prices[k] = leftArr[x];

            x++;

            k++;
        }

        while (y < n2)
        {
            prices[k] = rightArr[y];

            y++;

            k++;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of book prices:");

        int count = int.Parse(Console.ReadLine());

        int[] prices = new int[count];

        Console.WriteLine("Enter book prices:");

        for (int i = 0; i < count; i++)
        {
            prices[i] = int.Parse(Console.ReadLine());
        }

        SortPrices(prices, 0, count - 1);

        Console.WriteLine("Sorted book prices:");

        for (int i = 0; i < count; i++)
        {
            Console.Write(prices[i] + " ");
        }
    }
}

