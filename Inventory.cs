using System;

class ItemNode
{
    public string Name;
    public int Id;
    public int Qty;
    public double Price;
    
    public ItemNode Next;
    
    public ItemNode(int id, string name, int qty, double price)
    {
        Id = id;
        Name = name;
        
        Qty = qty;
        
        Price = price;
        
        Next = null;
    }
}

class InventoryList
{
    private ItemNode head;
    
    public void AddItem(int id, string name, int qty, double price, int pos = -1)
    {
        ItemNode newItem = new ItemNode(id, name, qty, price);
        if (head == null || pos == 0)
        {
            newItem.Next = head;
            
            head = newItem;
        }
        else
        {
            ItemNode temp = head;
            int count = 1;
            while (temp.Next != null && (pos == -1 || count < pos))
            {
                temp = temp.Next;
                count++;
            }
            newItem.Next = temp.Next;
            
            temp.Next = newItem;
        }
    }

    public void RemoveItem(int id)
    {
        if (head == null) return;
        
        if (head.Id == id)
        {
            head = head.Next;
            return;
        }
        ItemNode temp = head, prev = null;
        
        while (temp != null && temp.Id != id)
        {
            prev = temp;
            
            temp = temp.Next;
        }
        if (temp != null)
            prev.Next = temp.Next;
    }
    
    public void UpdateQty(int id, int qty)
    {
        ItemNode temp = head;
        
        while (temp != null)
        {
            if (temp.Id == id)
            {
                temp.Qty = qty;
                return;
            }
            temp = temp.Next;
        }
    }
    
    public void SearchItem(int id, string name = "")
    {
        ItemNode temp = head;
        while (temp != null)
        
        {
            if (temp.Id == id || temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            
                Console.WriteLine("ID: " + temp.Id + ", Name: " + temp.Name + ", Qty: " + temp.Qty + ", Price: " + temp.Price);
            temp = temp.Next;
        }
    }
    
    public void DisplayTotalValue()
    
    {
        double total = 0;
        ItemNode temp = head;
        
        while (temp != null)
        {
            total += temp.Price * temp.Qty;
            temp = temp.Next;
        }
        Console.WriteLine("Total Inventory Value: " + total);
    }
    
    public void SortInventory(string by, bool ascending = true)
    {
        if (head == null || head.Next == null) return;
        
        bool swapped;
        do
        {
            swapped = false;
            ItemNode temp = head;
            while (temp.Next != null)
            {
                bool condition = by == "name" ? string.Compare(temp.Name, temp.Next.Name) > 0 : temp.Price > temp.Next.Price;
                if ((ascending && condition) || (!ascending && !condition))
                {
                    (temp.Name, temp.Next.Name) = (temp.Next.Name, temp.Name);
                    
                    (temp.Id, temp.Next.Id) = (temp.Next.Id, temp.Id);
                    (temp.Qty, temp.Next.Qty) = (temp.Next.Qty, temp.Qty);
                    
                    (temp.Price, temp.Next.Price) = (temp.Next.Price, temp.Price);
                    swapped = true;
                }
                temp = temp.Next;
            }
        } while (swapped);
    }
    
    static void Main()
    {
        InventoryList list = new InventoryList();
        
        list.AddItem(1, "Item A", 10, 5.5);
        
        list.AddItem(2, "Item B", 5, 2.0, 0);
        list.AddItem(3, "Item C", 8, 7.0);
        
        list.DisplayTotalValue();
        
        Console.WriteLine("\nRemoving Item 2:");
        
        list.RemoveItem(2);
        
        Console.WriteLine("\nUpdating Item 3 Quantity:");
        
        list.UpdateQty(3, 12);
        
        Console.WriteLine("\nSearching for Item 3:");
        
        list.SearchItem(3);
        
        Console.WriteLine("\nSorting by Name:");
        
        list.SortInventory("name");
    }
}