using System;

class Product
{
   
    string productName;
    double price;
    static int totalProducts = 0;

    

    public Product(string name, double productPrice)
    {
        productName = name;

        price = productPrice;

        totalProducts++;
    }
    public void ShowDetails()
    {
        Console.WriteLine("Product Name: " + productName);

        Console.WriteLine("Price: " + price);
    }
    public static void ShowTotal()
    {
        Console.WriteLine("Total Products Created: " + totalProducts);
    }

    static void Main()
    {
        Console.WriteLine("Enter details for Product 1:");
        Console.Write("Name: ");
        string name1 = Console.ReadLine();
        Console.Write("Price: ");
        double price1 = Convert.ToDouble(Console.ReadLine());

        Product p1 = new Product(name1, price1);
        Console.WriteLine("\nEnter details for Product 2:");
        Console.Write("Name: ");
        string name2 = Console.ReadLine();
        Console.Write("Price: ");
        double price2 = Convert.ToDouble(Console.ReadLine());

        Product p2 = new Product(name2, price2);

        Console.WriteLine("Product 1 Details:");

        p1.ShowDetails();
        
        Console.WriteLine("Product 2 Details:");
        p2.ShowDetails();

        Product.ShowTotal();
    }
}
