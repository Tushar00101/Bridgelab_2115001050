using System;

class Book
{
    private string title;
    
    private string author;

    private double price;

    public Book()
    {
        title = "Unknown";
        author = "Unknown";

        price = 0.0;
    }

    public Book(string title, string author, double price)
    {
        this.title = title;

        this.author = author;

        this.price = price;
    }

    public void Display()
    {
        Console.WriteLine("Title: " + title);

        Console.WriteLine("Author: " + author);

        Console.WriteLine("Price: $" + price);
    }

    static void Main(string[] args)
    {
        Book book1 = new Book();
        Console.WriteLine("Book 1:");
        book1.Display();
        Console.WriteLine("Enter book details:");
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Author: ");
        string author = Console.ReadLine();
        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine());
        Book book2 = new Book(title, author, price);
        Console.WriteLine("Book 2:");
        book2.Display();
    }
}