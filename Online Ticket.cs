using System;
using System.Collections.Generic;

class Ticket
{
    public int Id;
    public string Customer, Movie;
    public string Seat;
    public DateTime BookingTime;
    
    public Ticket Next;
    
    public Ticket(int id, string customer, string movie, string seat)
    {
        Id = id;
        
        Customer = customer;
        
        Movie = movie;
        
        Seat = seat;
        
        BookingTime = DateTime.Now;
        
        Next = null;
    }
}

class TicketSystem
{
    private Ticket head;
    
    public void AddTicket(int id, string customer, string movie, string seat)
    {
        Ticket newTicket = new Ticket(id, customer, movie, seat);
        if (head == null)
        {
            head = newTicket;
            
            head.Next = head;
        }
        else
        {
            Ticket temp = head;
            
            while (temp.Next != head)
                temp = temp.Next;
            temp.Next = newTicket;
            
            newTicket.Next = head;
        }
    }
    
    public void RemoveTicket(int id)
    {
        if (head == null) return;
        
        Ticket temp = head, prev = null;
        do
        {
            if (temp.Id == id)
            {
                if (prev == null)
                {
                    Ticket last = head;
                    while (last.Next != head)
                        last = last.Next;
                    if (head == head.Next)
                        head = null;
                        
                    else
                    {
                        head = head.Next;
                        
                        last.Next = head;
                    }
                }
                else
                    prev.Next = temp.Next;
                return;
            }
            prev = temp;
            temp = temp.Next;
            
        } while (temp != head);
    }
    
    public void DisplayTickets()
    {
        if (head == null) return;
        
        Ticket temp = head;
        do
        {
            Console.WriteLine($"ID: {temp.Id}, Customer: {temp.Customer}, Movie: {temp.Movie}, Seat: {temp.Seat}, Time: {temp.BookingTime}");
            temp = temp.Next;
            
        } while (temp != head);
    }
    
    public void SearchTicket(string key)
    {
        if (head == null) return;
        Ticket temp = head;
        do
        {
            if (temp.Customer == key || temp.Movie == key)
                Console.WriteLine($"Found - ID: {temp.Id}, Customer: {temp.Customer}, Movie: {temp.Movie}, Seat: {temp.Seat}");
            temp = temp.Next;
        } while (temp != head);
    }
    
    public int CountTickets()
    {
        if (head == null) return 0;
        
        int count = 0;
        
        Ticket temp = head;
        do
        {
            count++;
            temp = temp.Next;
            
        } while (temp != head);
        
        return count;
    }
    
    static void Main()
    {
        TicketSystem system = new TicketSystem();
        system.AddTicket(1, "Ram", "Inception", "A1");
        
        system.AddTicket(2, "Bobby", "Inception", "A2");
        
        system.AddTicket(3, "Aman", "Matrix", "B1");
        
        
        
        Console.WriteLine("Displaying Tickets:");
        
        system.DisplayTickets();
        
        Console.WriteLine("Searching for tickets by movie 'Inception':");
        
        system.SearchTicket("Inception");
        
        Console.WriteLine("Total Booked Tickets: " + system.CountTickets());
        
        Console.WriteLine("Removing Ticket ID 2 and displaying updated list:");
        
        system.RemoveTicket(2);
        
        system.DisplayTickets();
    }
}
