using System;
using System.Collections.Generic;

class StockSpan
{
    public static int[] CalcSpan(int[] prices)
    {
        int n = prices.Length;
        
        int[] span = new int[n];
        
        Stack<int> stk = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            while (stk.Count > 0 && prices[stk.Peek()] <= prices[i])
                stk.Pop();

            span[i] = (stk.Count == 0) ? (i + 1) : (i - stk.Peek());
            
            stk.Push(i);
        }

        return span;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter stock prices:");
        
        int[] prices = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int[] spans = CalcSpan(prices);

        Console.WriteLine("Stock spans:");
        
        Console.WriteLine(string.Join(" ", spans));
    }
}

