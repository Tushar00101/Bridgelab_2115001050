using System;
using System.Collections.Generic;

class StackQueue
{
    private Stack<int> s1 = new Stack<int>();

    private Stack<int> s2 = new Stack<int>();

    public void Enq(int val)
    {
        s1.Push(val);
    }

    public int Deq()
    {
        if (s2.Count == 0)

        {
            if (s1.Count == 0)
                return -1;
            while (s1.Count > 0)

                s2.Push(s1.Pop());
        }
        return s2.Pop();
    }

    static void Main(string[] args)
    {
        StackQueue q = new StackQueue();

        Console.WriteLine("Enter commands (enq x / deq / exit):");

        while (true)
        {
            string[] cmd = Console.ReadLine().Split();

            if (cmd[0] == "enq")
            {
                q.Enq(int.Parse(cmd[1]));
            }
            else if (cmd[0] == "deq")
            {
                int res = q.Deq();

                if (res == -1)
                    Console.WriteLine("Queue is empty");

                else
                    Console.WriteLine("Dequeued: " + res);
            }
            else if (cmd[0] == "exit")
            {
                break;
            }
        }
    }
}

