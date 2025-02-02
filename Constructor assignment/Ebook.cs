using System;

class Book
{
    public string ISBN;
    protected string title;
    private string author;

    public Book(string isbn, string bookTitle, string bookAuthor)
    {
        ISBN = isbn;

        title = bookTitle;

        author = bookAuthor;
    }
    public string GetAuthor()
    {
        return author;
    }
    public void SetAuthor(string bookAuthor)
    {
        author = bookAuthor;
    }    public void Display()
    {
        Console.WriteLine("ISBN: " + ISBN);

        Console.WriteLine("Title: " + title);

        Console.WriteLine("Author: " + author);
    }

}

class EBook : Book
{

    public EBook(string isbn, string bookTitle, string bookAuthor)
        : base(isbn, bookTitle, bookAuthor) 
    {
    }

    
    public void DisplayEBook()
    {
        Console.WriteLine("ISBN: " + ISBN); 

        Console.WriteLine("Title: " + title); 

        Console.WriteLine("Author: " + GetAuthor()); 
    }
}

class Program
{
    static void Main()
    {
        Book book1 = new Book("1234567890", "The Great Book", "John Doe");
        book1.Display();
        book1.SetAuthor("Jane Doe");
        Console.WriteLine("\nUpdated Book Details:");
        book1.Display();
        EBook ebook1 = new EBook("9876543210", "The Amazing EBook", "Mark Twain");
        Console.WriteLine("\nEBook Details:");
        ebook1.DisplayEBook();
    }
}