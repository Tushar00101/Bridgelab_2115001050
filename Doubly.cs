using System;
using System.Collections.Generic;
class Node
{
    public string title;
    public string director;

    public float rating;

    public int year;

    public Node next;
    public Node previous;

    public Node(string name, string director, int year, float rating)
    {
        this.title = name;
        this.director = director;
        this.year = year;
        this.rating = rating;
    }
}

class Movie
{
    private Node head;
    private Node tail;

    private int size=0;
    public void AddLast(string title, string director, int year, float rating)
    {
        Node node = new Node(title, director, year, rating);

        if (head == null)
        {
            head = tail = node;
            size++;
            return;
        }


        Node temp = tail;
        tail.next = node;
        tail = node;
        tail.previous = temp;
        size++;
        return;
        // node.previous = prev;


    }

    public void AddFirst(string title, string director, int year, float rating)
    {
        Node node = new Node(title, director, year, rating);
        if (head == null)
        {
            head = tail = node;
            size++;
            return;
        }

        node.next = head;
        head.previous = node;
        head = node;
        size++;
        return;
    }

    public void Add(string title, string director, int year, float rating, int pos)
    {
        if (pos <= 0 || pos > size + 1)
        {
            Console.WriteLine("Invalid position");
            return;
        }
        if (pos == 1)
        {
            AddFirst(title, director, year, rating);
            return;
        }
        if (pos == size + 1)
        {
            AddLast(title, director, year, rating);
            return;
        }
        Node temp = head;
        Node node = new Node(title, director, year, rating);
        for (int i = 1; i < pos - 1; i++)
        {
            temp = temp.next;
        }

        node.next = temp.next;
        node.previous = temp;
        temp.next = node;
        // if (node.next == null)
        // {

        // }
        node.next.previous = node;
        size++;
        return;
        
    }
    public Node Remove(string title)
    {
        if (head == null)
        {
            System.Console.WriteLine("No recrod found!");
            return null;
        }
        if (head.title == title)
        {
            Node discard = head;
            head = head.next;
            head.previous = null;
            return discard;

        }

        Node temp = head;
        while (temp != null)
        {
            if (temp.title == title)

            {
                Node cur = temp;
                temp.previous.next = cur.next;
                if (cur.next == null)
                {
                    tail = temp.previous;
                    return null;
                }
                cur.next.previous = cur.previous;
                return null;
            }
            temp = temp.next;
        }
        return null;
    }

    public List<Node> searchDirector(string name)
    {
        List<Node> allMovies = new List<Node>();
        Node temp = head;
        while (temp != null)
        {
            if (temp.director == name)
            {
                allMovies.Add(temp);
            }
            temp = temp.next;
        }
        return allMovies;
    }

    public List<Node> searchRating(float rate)
    {
        List<Node> allMovies = new List<Node>();
        Node temp = head;
        while (temp != null)
        {
            if (temp.rating == rate)
            {
                allMovies.Add(temp);
            }
            temp = temp.next;
        }
        return allMovies;
    }

    public void Update(string title,int rating)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.title == title)
            {
                temp.rating = rating;
                return;
            }
            temp = temp.next;
        }
    }
    public void Display()
    {
        Node node = head;
        while (node != null)
        {
            System.Console.WriteLine(node.title + " " + node.director + " " + node.year + " " + node.rating);
            node = node.next;
        }
        Console.WriteLine("Forward Display");

    }

    public void Backward()
    {
        Node node = tail;
        while (node != null)
        {
            System.Console.WriteLine(node.title + " " + node.director + " " + node.year + " " + node.rating);
            node = node.previous;
        }
        Console.WriteLine("Backward Display");
    }

    static void Main(string[] args)
    {
        Movie m1 = new Movie();
        m1.AddLast("Tushar", "Tushar", 2025, 5f);
        m1.AddLast("kumar", "kumar", 2025, 5f);
        m1.AddLast("last", "kumar", 2025, 5f);
        m1.Remove("kumar");
        foreach (Node n in m1.searchRating(5f))
        {
            Console.WriteLine(n.title + " ");
        }
        m1.Update("Tushar", 1);
        m1.Add("one", "one", 0000, 2f, 1);
        m1.Add("last", "last", 0000, 2f, m1.size+1);
        Console.WriteLine(m1.size);
        m1.Add("five", "two", 0000, 2f, 5);
        m1.Display();

        m1.Backward();

    }
}