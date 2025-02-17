using System;
using System.Text;

class StrComp
{
    public static void StrConcat(int n)
    {
        string txt = "";
        
        for (int i = 0; i < n; i++)
        {
            txt += "a"; 
        }
    }

    public static void SBConcat(int n)
    {
        StringBuilder sb = new StringBuilder();
        
        for (int i = 0; i < n; i++)
        {
            sb.Append("a");
        }
    }

    static void Main(string[] args)
    {
        int n = 100000; 

        var sw = System.Diagnostics.Stopwatch.StartNew();

        sw.Restart();
        
        StrConcat(n);
        
        sw.Stop();
        
        Console.WriteLine("String: " + sw.ElapsedMilliseconds + " ms");

        sw.Restart();
        
        SBConcat(n);
        
        sw.Stop();
        
        Console.WriteLine("StringBuilder: " + sw.ElapsedMilliseconds + " ms");
    }
}

