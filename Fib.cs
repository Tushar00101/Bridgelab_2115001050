using System;

class FibComp
{
    public static int FibRec(int n)
    {
        if (n <= 1) return n;

        return FibRec(n - 1) + FibRec(n - 2);
    }

    public static int FibItr(int n)
    {
        if (n <= 1) return n;
        int a = 0, b = 1, sum;

        for (int i = 2; i <= n; i++)
        {
            sum = a + b;

            a = b;

            b = sum;
        }
        return b;
    }

    static void Main(string[] args)
    {
        int n = 30;

        var sw = System.Diagnostics.Stopwatch.StartNew();

        sw.Restart();
        
        Console.WriteLine("Recursive Fibonacci: " + (n > 30 ? "Too slow!" : FibRec(n)));

        sw.Stop();

        Console.WriteLine("Recursive Time: " + sw.ElapsedMilliseconds + " ms");


        sw.Restart();
        Console.WriteLine("Iterative Fibonacci: " + FibItr(n));

        sw.Stop();

        Console.WriteLine("Iterative Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
