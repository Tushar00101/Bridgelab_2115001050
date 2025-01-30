using System;


class Substring{
    
    static void Main(string [] args){

        Console.Write("Enter a string; ");
        string str = Console.ReadLine();

        Console..Write("Enter a substring");
        string s = Console.ReadLine();

        string temp = "";
        
        int count = 0;

        for(int i=0;i<str.Length;i++){
            temp = "";
            for(int j=i;j<str.Length;j++){

                temp += str[j] + "";

                if (s.Length == temp.Length)
                {
                    
                    if (s == temp)
                    {
                        count++;
                    }
                    else
                    {
                        temp = "";
                        break;
                    }
                }
                
            }

        }
        Console.WriteLine(count);
    }
}