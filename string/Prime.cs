using System;


class Prime{

    static void GetPrime(int n)
    {
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                Console.Write("Entered numbered " + n + " is not a prime");
                return;
            }
        }

        Console.Write("Entered numbered " + n + " is a prime");
        return;

    }
    static void Main(string[] args){
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if(n<=1){
            Console.Write("Entered numbered "+n+" is not a prime");
        }
        else{
            GetPrime(n);
        }
    }
}