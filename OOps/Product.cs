using System;

class Product
{
    private static double Discount = 10.0;

    private readonly int ProductID;
    private string ProductName;

    private double Price;
    private int Quantity;


    public Product(string ProductName, int ProductID, double Price, int Quantity)
    {
        this.ProductName = ProductName;

        this.ProductID = ProductID;

        this.Price = Price;

        this.Quantity = Quantity;
    }

    public void Display()
    {
        if (this is Product)
        {
            Console.WriteLine("Product: " + ProductName);

            Console.WriteLine("ID: " + ProductID);
            Console.WriteLine("Price: " + Price);
            
            Console.WriteLine("Quantity: " + Quantity);

            Console.WriteLine("Discount: " + Discount + "%");
        }
    }

    public static void UpdateDiscount(double newDiscount)

    {
        Discount = newDiscount;
    }

    static void Main(string[] args)
    {
        Product prod1 = new Product("Mobile", 201, 800.50, 2);

        Product prod2 = new Product("Phone", 202, 500.75, 3);

        prod1.Display();

        prod2.Display();

        Product.UpdateDiscount(15.0);

        Console.WriteLine("Updated Discount:");

        prod1.Display();

        prod2.Display();
    }
}
