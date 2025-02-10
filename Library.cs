using System;
using System.Collections.Generic;

abstract class LibraryItem
{
    
    protected int itemId;
    
    protected string title;
    
    protected string author;

    public int ItemId { get { return itemId; } set { itemId = value; } }
    
    public string Title { get { return title; } set { title = value; } }
    
    public string Author { get { return author; } set { author = value; } }

    public LibraryItem(int id, string ttl, string auth)
    {
        itemId = id;
        title = ttl;
        author = auth;
    }

    public abstract int GetLoanDuration();

    public void GetItemDetails()
    {
        Console.WriteLine("ID: " + itemId + ", Title: " + title + ", Author: " + author);
    }
}

interface IReservable
{
    void ReserveItem();
    
    bool CheckAvailability();
}

class Book : LibraryItem, IReservable
{
    public Book(int id, string ttl, string auth) : base(id, ttl, auth) { }

    public override int GetLoanDuration()
    {
        return 14;
    }

    public void ReserveItem()
    {
        Console.WriteLine("Book reserved: " + title);
    }

    public bool CheckAvailability()
    {
        return true;
    }
}

class Magazine : LibraryItem
{
    public Magazine(int id, string ttl, string auth) : base(id, ttl, auth) { }

    public override int GetLoanDuration()
    {
        return 7;
    }
}

class DVD : LibraryItem, IReservable
{
    public DVD(int id, string ttl, string auth) : base(id, ttl, auth) { }

    public override int GetLoanDuration()
    {
        return 3;
    }

    public void ReserveItem()
    {
        Console.WriteLine("DVD reserved: " + title);
    }

    public bool CheckAvailability()
    {
        return false;
    }
}

class Program
{
    static void Main()
    {
        List<LibraryItem> items = new List<LibraryItem>();
        
        items.Add(new Book(1, "C# Basics", "Ram"));
        
        items.Add(new Magazine(2, "Tech Weekly", "Jatin"));
        
        items.Add(new DVD(3, "C# Tutorial", "Tushar"));

        foreach (LibraryItem item in items)
        {
            item.GetItemDetails();
            
            Console.WriteLine("Loan Duration: " + item.GetLoanDuration() + " days\n");
        }
    }
}
