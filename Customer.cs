using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; }

    public int Price { get; }

    public Product(string name, int price)
    {
        Name = name;

        Price = price;
    }

    public void Show()
    {
        Console.WriteLine("  Product: " + Name + " - ₹" + Price);
    }
}

class Order
{
    public int Id { get; }
    private List<Product> products;

    public Order(int id)
    {
        Id = id;

        products = new List<Product>();
    }

    public void Add(Product prod)
    {
        products.Add(prod);
    }

    public void Show()
    {
        Console.WriteLine(" Order ID: " + Id);

        foreach (var prod in products)
        {
            prod.Show();
        }
    }
}

class Customer
{
    public string Name { get; }
    private List<Order> orders;


    public Customer(string name)
    {
        Name = name;

        orders = new List<Order>();
    }

    public void PlaceOrder(Order ord)
    {
        orders.Add(ord);

        Console.WriteLine(Name + " placed Order ID: " + ord.Id);
    }

    public void Show()
    {
        Console.WriteLine("Customer: " + Name);

        foreach (var ord in orders)
        {
            ord.Show();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer("Rajesh Kumar");

        Product p1 = new Product("Smartphone", 15000);

        Product p2 = new Product("Laptop", 45000);

        Product p3 = new Product("Headphones", 2000);

        Order o1 = new Order(101);

        o1.Add(p1);

        o1.Add(p3);

        Order o2 = new Order(102);

        o2.Add(p2);

        c1.PlaceOrder(o1);

        c1.PlaceOrder(o2);

        Console.WriteLine();

        c1.Show();
    }
}