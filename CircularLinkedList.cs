using System;

class TaskNode
{
    public int Id;
    public string Name;
    public int Prio;
    public DateTime Due;
    
    public TaskNode Next;
    
    public TaskNode(int id, string name, int prio, DateTime due)
    {
        Id = id;
        Name = name;
        Prio = prio;
        
        Due = due;
        Next = this;
    }
}

class TaskList
{
    private TaskNode head;
    private TaskNode current;
    
    public void AddTask(int id, string name, int prio, DateTime due, int pos = -1)
    {
        TaskNode newTask = new TaskNode(id, name, prio, due);
        if (head == null)
        {
            head = newTask;
            
            current = head;
        }
        else if (pos == 0)
        {
            TaskNode last = head;
            while (last.Next != head) last = last.Next;
            newTask.Next = head;
            
            last.Next = newTask;
            head = newTask;
        }
        else
        {
            TaskNode temp = head;
            int count = 1;
            while (temp.Next != head && (pos == -1 || count < pos))
            {
                temp = temp.Next;
                count++;
            }
            newTask.Next = temp.Next;
            
            temp.Next = newTask;
        }
    }

    public void RemoveTask(int id)
    {
        if (head == null) return;
        
        TaskNode temp = head, prev = null;
        do
        {
            if (temp.Id == id)
            {
                if (temp == head)
                {
                    TaskNode last = head;
                    
                    while (last.Next != head) last = last.Next;
                    
                    head = head.Next;
                    last.Next = head;
                }
                else
                    prev.Next = temp.Next;
                return;
            }
            prev = temp;
            temp = temp.Next;
            
        } while (temp != head);
    }
    
    public void ViewTask()
    {
        if (current != null)
        {
            Console.WriteLine("Current Task: " + current.Name);
            
            current = current.Next;
        }
    }
    
    public void DisplayAll()
    {
        if (head == null) return;
        TaskNode temp = head;
        do
        {
            Console.WriteLine("ID: " + temp.Id + ", Name: " + temp.Name + ", Prio: " + temp.Prio + ", Due: " + temp.Due);
            
            temp = temp.Next;
            
        } while (temp != head);
    }
    
    public void SearchByPrio(int prio)
    {
        if (head == null) return;
        
        TaskNode temp = head;
        do
        {
            if (temp.Prio == prio)
            
                Console.WriteLine("ID: " + temp.Id + ", Name: " + temp.Name);
            temp = temp.Next;
        } while (temp != head);
    }
    
    static void Main()
    {
        TaskList list = new TaskList();
        list.AddTask(1, "Task A", 2, DateTime.Now.AddDays(1));
        
        list.AddTask(2, "Task B", 1, DateTime.Now.AddDays(2), 0);
        
        list.AddTask(3, "Task C", 3, DateTime.Now.AddDays(3));
        list.DisplayAll();
        
        Console.WriteLine("\nRemoving Task 2:");
        
        list.RemoveTask(2);
        list.DisplayAll();
        
        Console.WriteLine("\nSearching by Prio 3:");
        
        list.SearchByPrio(3);
        
        Console.WriteLine("\nView Next Task:");
        
        list.ViewTask();
    }
}
