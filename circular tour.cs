using System;

class CircularTour
{
    public static int FindStart(int[] petrol, int[] dist)
    {
        int n = petrol.Length;
        
        int start = 0, deficit = 0, balance = 0;

        for (int i = 0; i < n; i++)
        {
            balance += petrol[i] - dist[i];

            if (balance < 0)
            {
                start = i + 1;
                
                deficit += balance;
                
                balance = 0;
            }
        }

        return (balance + deficit >= 0) ? start : -1;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter petrol values:");
        
        int[] petrol = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        Console.WriteLine("Enter distance values:");
        
        int[] dist = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int start = FindStart(petrol, dist);

        Console.WriteLine(start == -1 ? "No possible tour" : "Start at pump: " + start);
    }
}

