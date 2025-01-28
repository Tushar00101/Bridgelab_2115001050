using System;

class SumOfNaturalNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the Number: ");
		
        int month = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Sum is: "+Sum(n));
        
    }

    static int Sum(int n)
    {
        int sum=0;
		for(int i=1;i<=n;i++){
			sum+=i;
		}
		return sum;
    }
}
