using System;

class ScoreSort
{
    public static void SortScores(int[] scores)
    {
        int n = scores.Length;
        
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (scores[j] < scores[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = scores[minIndex];
            
            scores[minIndex] = scores[i];
            
            scores[i] = temp;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of students:");
        
        int count = int.Parse(Console.ReadLine());
        
        int[] scores = new int[count];

        Console.WriteLine("Enter exam scores:");
        
        for (int i = 0; i < count; i++)
        {
            scores[i] = int.Parse(Console.ReadLine());
        }

        SortScores(scores);

        Console.WriteLine("Sorted exam scores:");
        
        for (int i = 0; i < count; i++)
        {
            Console.Write(scores[i] + " ");
        }
    }
}

