using System;

class MarksSort
{
    public static void SortMarks(int[] marks)
    {
        int n = marks.Length;
        
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (marks[j] > marks[j + 1])
                {
                    int temp = marks[j];
                    
                    marks[j] = marks[j + 1];
                    
                    marks[j + 1] = temp;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of students:");


        int count = int.Parse(Console.ReadLine());

        int[] marks = new int[count];

        Console.WriteLine("Enter marks:");


        for (int i = 0; i < count; i++)
        {
            marks[i] = int.Parse(Console.ReadLine());
        }

        SortMarks(marks);

        Console.WriteLine("Sorted marks:");


        for (int i = 0; i < count; i++)
        {
            Console.Write(marks[i] + " ");
        }
    }
}
