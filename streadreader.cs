using System;
using System.IO;

class FileComp
{
    public static void ReadSR(string path)
    {
        using (StreamReader sr = new StreamReader(path))
        {
            while (sr.ReadLine() != null) { }
        }
    }

    public static void ReadFS(string path)
    {
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[1024];
            
            while (fs.Read(buffer, 0, buffer.Length) > 0) { }
        }
    }

    static void Main(string[] args)
    {
        string path = "largefile.txt"; 

        var sw = System.Diagnostics.Stopwatch.StartNew();

        sw.Restart();
        
        ReadSR(path);
        
        sw.Stop();
        
        Console.WriteLine("StreamReader: " + sw.ElapsedMilliseconds + " ms");

        sw.Restart();
        
        ReadFS(path);
        
        sw.Stop();
        
        Console.WriteLine("FileStream: " + sw.ElapsedMilliseconds + " ms");
    }
}
