using System;

class Book
{
    private static string LibraryName = "City Library";
    private readonly int ISBN;

    private string Title;
    private string Author;


    public Book(string Title, string Author, int ISBN)
    {
        this.Title = Title;
        this.Author = Author;

        this.ISBN = ISBN;
    }

    public void Display()
    {
        if (this is Book)
        {
            Console.WriteLine("Library: " + LibraryName);

            Console.WriteLine("Title: " + Title);

            Console.WriteLine("Author: " + Author);

            Console.WriteLine("ISBN: " + ISBN);
        }
    }

    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library Name: " + LibraryName);
    }

    static void Main(string[] args)
    {
        Book book1 = new Book("Harry Potter", "Jk rowllings", 123456);

        Book book2 = new Book("A girl with dragon tattoo", "Harper Lee", 789012);

        book1.Display();

        book2.Display();

        Book.DisplayLibraryName();
    }
}
