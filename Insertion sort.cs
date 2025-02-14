using System;

class EmpSort
{
    public static void SortIds(int[] ids)
    
    {
        int n = ids.Length;
        for (int i = 1; i < n; i++)
        {
            int key = ids[i];
            
            int j = i - 1;

            while (j >= 0 && ids[j] > key)
            {
                ids[j + 1] = ids[j];
                j--;
            }
            ids[j + 1] = key;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of employees:");
        
        int count = int.Parse(Console.ReadLine());
        
        int[] ids = new int[count];

        Console.WriteLine("Enter employee IDs:");
        
        for (int i = 0; i < count; i++)
        {
            ids[i] = int.Parse(Console.ReadLine());
        }

        SortIds(ids);

        Console.WriteLine("Sorted employee IDs:");
        
        for (int i = 0; i < count; i++)
        {
            Console.Write(ids[i] + " ");
        }
    }
}

