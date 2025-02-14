using System;

class AgeSort
{
    public static void SortAges(int[] ages)
    {
        int maxAge = 18;
        
        int minAge = 10;
        
        int range = maxAge - minAge + 1;
        
        int[] count = new int[range];
        
        int[] output = new int[ages.Length];

        for (int i = 0; i < ages.Length; i++)
        {
            count[ages[i] - minAge]++;
        }

        for (int i = 1; i < range; i++)
        {
            count[i] += count[i - 1];
        }

        for (int i = ages.Length - 1; i >= 0; i--)
        {
            output[count[ages[i] - minAge] - 1] = ages[i];
            
            count[ages[i] - minAge]--;
        }

        for (int i = 0; i < ages.Length; i++)
        {
            ages[i] = output[i];
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of students:");
        
        int count = int.Parse(Console.ReadLine());
        
        int[] ages = new int[count];

        Console.WriteLine("Enter student ages (10 to 18):");
        
        for (int i = 0; i < count; i++)
        {
            ages[i] = int.Parse(Console.ReadLine());
        }

        SortAges(ages);

        Console.WriteLine("Sorted student ages:");
        
        for (int i = 0; i < count; i++)
        {
            Console.Write(ages[i] + " ");
        }
    }
}
