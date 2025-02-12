using System;
class Task
{
    public int id;
    public int priority;

    public string date;
    public string name;

    public Task next;

    public Task(int id, string name, string date, int priority)
    {
        this.id = id;
        this.name = name;
        this.date = date;
        this.priority = priority;
    }
}


class Scheduler
{
    Task head = null;
    public void Add(int id, string name, string date, int priority)
    {
        Task node = new Task(id, name, date, priority);
        if (head == null)
        {
            head = node;
            head.next = head;
            return;
        }
        Task temp = head;

        while (head.next != head)
        {
            head = head.next;
        }

        temp.next = node;
        node.next = head;


    }

    public void AddFirst(int id, string name, string date, int priority)
    {
        Task node = new Task(id, name, date, priority);
        if (head == null)
        {
            head = node;
            head.next = head;
            return;
        }
        Task temp = head;
        while (temp.next != head)
        {
            temp = temp.next;
        }
        temp.next = node;
        node.next = head;
        head = node;
        return;
    }

    public void Delete(int id)
    {
        if (head == null) return;

        if (head.next == head && head.id == id)
        {
            head = null;
            return;
        }

        if (head.id == id)
        {
            // head = head.next;
            Task node = head;
            while (node.next != head)
            {
                node = node.next;
            }
            head = head.next;
            node.next = head;
            return;
        }

        Task temp = head.next;
        Task prev = head;
        while (temp.next != head)
        {
            if (temp.id == id)
            {
                prev.next = prev.next.next;
                return;
            }
            prev = temp;
            temp = temp.next;

        }
        if(temp.id==id)
        prev.next = head;
    }

    public void Search(int priority)
    {
        Task node = head;
        while (node.next != head)
        {
            if (node.priority == priority)
            {
                Console.WriteLine(node.id + " ");
                return;
            }
        }
    }
    public void Display()
    {
        if (head == null) return;

        Task temp = head;

        while (temp.next != head)
        {
            Console.Write(temp.id + " ");
            temp = temp.next;
        }
        Console.WriteLine(temp.id);
        return;


    }

    static void Main(string[] args)
    {
        Scheduler cl = new Scheduler();
        cl.Add(1, "Tushar", "Now", 1);
        cl.Add(2, "Tushar", "Now", 1);
        cl.AddFirst(3, "tushar", "noe", 2);
        cl.Delete(1);
        cl.Display();
    }
}