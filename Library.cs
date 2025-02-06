using System;

using System.Collections.Generic;

class Book
{
    public string Title { get; }
    public string Author { get; }

    public Book(string title, string author)
    {
        Title = title;

        Author = author;
    }

    public void Show()
    {
        Console.WriteLine("Title: " + Title + ", Author: " + Author);
    }
}

class Library
{
    public string Name { get; }

    private List<Book> books;

    public Library(string name)
    {
        Name = name;

        books = new List<Book>();
    }

    public void Add(Book book)
    {
        books.Add(book);
    }

    public void Show()
    {
        Console.WriteLine("Library: " + Name);

        foreach (var book in books)
        {
            book.Show();
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        Book b1 = new Book("Wings", "Kalam");


        Book b2 = new Book("My Experiments", "Gandhi");

        Library lib1 = new Library("Public Library");

        Library lib2 = new Library("City Library");


        lib1.Add(b1);

        lib1.Add(b2);

        lib1.Show();

        Console.WriteLine();

        lib2.Show();
    }
}