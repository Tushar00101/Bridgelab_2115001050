using System;
using System.Collections.Generic;

class SortStack
{
    public static void Sort(Stack<int> stk)
    
    {
        if (stk.Count == 0)
            return;

        int top = stk.Pop();
        Sort(stk);
        Insert(stk, top);
    }

    private static void Insert(Stack<int> stk, int val)
    
    {
        if (stk.Count == 0 || stk.Peek() <= val)
        {
            stk.Push(val);
            
            return;
        }

        int temp = stk.Pop();
        
        Insert(stk, val);
        
        stk.Push(temp);
    }

    static void Main(string[] args)
    {
        Stack<int> stk = new Stack<int>();
        
        Console.WriteLine("Enter stack elements (space-separated):");
        
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        
        
        foreach (int num in arr)
            stk.Push(num);

        Sort(stk);

        Console.WriteLine("Sorted Stack:");
        
        while (stk.Count > 0)
            Console.Write(stk.Pop() + " ");
    }
}

