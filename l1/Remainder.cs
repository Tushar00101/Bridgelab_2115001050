using System;

class Chocolate
{
    static void Main()
    {
        Console.WriteLine("Number of chocolates:");
		
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Number of children:");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        if (numberOfChildren <= 0)
        {
            Console.WriteLine("Number of children should be greater than zero.");
            return;
        }

        int[] result = DivideChocolates(numberOfChocolates, numberOfChildren);

        Console.WriteLine($"Each child will get {result[0]} chocolates.");
        Console.WriteLine($"The remaining chocolates are: {result[1]}");
    }

    public static int[] DivideChocolates(int numberOfChocolates, int numberOfChildren)
    {
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;
        return new int[] { chocolatesPerChild, remainingChocolates };
    }
}
