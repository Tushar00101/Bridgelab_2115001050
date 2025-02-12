using System;

class BookNode
{
    public string Title, Author, Genre;
    public int Id;
    public bool Available;
    
    public BookNode Prev, Next;
    
    public BookNode(int id, string title, string author, string genre, bool available)
    {
        Id = id;
        Title = title;
        
        Author = author;
        
        Genre = genre;
        Available = available;
        
        Prev = Next = null;
    }
}

class LibraryList
{
    private BookNode head, tail;
    
    private int count = 0;
    
    public void AddBook(int id, string title, string author, string genre, bool available, int pos = -1)
    {
        BookNode newBook = new BookNode(id, title, author, genre, available);
        if (head == null || pos == 0)
        {
            newBook.Next = head;
            if (head != null) head.Prev = newBook;
            
            head = newBook;
            if (tail == null) tail = head;
        }
        else
        {
            BookNode temp = head;
            
            int index = 1;
            while (temp.Next != null && (pos == -1 || index < pos))
            {
                temp = temp.Next;
                index++;
            }
            newBook.Next = temp.Next;
            
            newBook.Prev = temp;
            
            if (temp.Next != null) temp.Next.Prev = newBook;
            temp.Next = newBook;
            if (newBook.Next == null) tail = newBook;
        }
        count++;
    }

    public void RemoveBook(int id)
    {
        BookNode temp = head;
        while (temp != null && temp.Id != id)
            temp = temp.Next;
            
        if (temp == null) return;
        
        if (temp.Prev != null) temp.Prev.Next = temp.Next;
        
        if (temp.Next != null) temp.Next.Prev = temp.Prev;
        if (temp == head) head = temp.Next;
        
        if (temp == tail) tail = temp.Prev;
        count--;
    }
    
    public void SearchBook(int id, string title = "", string author = "")
    {
        BookNode temp = head;
        
        while (temp != null)
        {
            if (temp.Id == id || temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase) || temp.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("ID: " + temp.Id + ", Title: " + temp.Title + ", Author: " + temp.Author + ", Genre: " + temp.Genre + ", Available: " + temp.Available);
            temp = temp.Next;
        }
    }
    
    public void UpdateStatus(int id, bool available)
    {
        BookNode temp = head;
        while (temp != null)
        {
            if (temp.Id == id)
            {
                temp.Available = available;
                
                return;
            }
            temp = temp.Next;
        }
    }
    
    public void DisplayBooks(bool reverse = false)
    {
        BookNode temp = reverse ? tail : head;
        
        while (temp != null)
        {
            Console.WriteLine("ID: " + temp.Id + ", Title: " + temp.Title + ", Author: " + temp.Author + ", Genre: " + temp.Genre + ", Available: " + temp.Available);
            temp = reverse ? temp.Prev : temp.Next;
        }
    }
    
    public int CountBooks()
    {
        return count;
    }
    
    static void Main()
    {
        LibraryList list = new LibraryList();
        list.AddBook(1, "Book A", "Author X", "Fiction", true);
        
        list.AddBook(2, "Book B", "Author Y", "Mystery", false, 0);
        
        list.AddBook(3, "Book C", "Author Z", "Sci-Fi", true);
        
        
        Console.WriteLine("All Books:");
        
        list.DisplayBooks();
        
        Console.WriteLine("Removing Book 2:");
        
        list.RemoveBook(2);
        list.DisplayBooks();
        
        Console.WriteLine("Updating Availability of Book 3:");
        
        list.UpdateStatus(3, false);
        list.DisplayBooks();
        
        Console.WriteLine("Searching for Book C:");
        
        list.SearchBook(3);
        
        Console.WriteLine("\nTotal Books: " + list.CountBooks());
    }
}
