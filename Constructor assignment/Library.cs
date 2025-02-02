using System;

class Library
{
    private string title;
    private string author;
    private double price;
    private bool available;

    // Constructor
    public Library(string title, string author, double price, bool available)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        this.available = available;
    }

    public void BorrowBook()
    {
        if (available)
        {
            available = false;

            Console.WriteLine("You borrowed the book: " + title);
        }
        else
        {
            Console.WriteLine("Sorry, the book is not available");
        }
    }

    public void BookInfo()
    {
        
        Console.WriteLine("Title: " + title);
                Console.WriteLine("Author: " + author);

        Console.WriteLine("Price: $" + price);

        Console.WriteLine("Available: " + (available ? "Yes" : "No"));
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter book details:");
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Author: ");
        string author = Console.ReadLine();
        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine());

        Library book = new Library(title, author, price, true);
        Console.WriteLine("\nBook Details:");
        book.BookInfo();
        Console.WriteLine("\nborrowing? the book...");
        book.BorrowBook();
        Console.WriteLine("\nUpdated Book Details:");
        book.BookInfo();
    }
}
