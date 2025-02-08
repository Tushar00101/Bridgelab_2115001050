using System;
interface Worker
{
    void PerformDuties();
}
class Person
{
    public string Name;
    public int Id;
    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }
    public virtual void DisplayRole()
    {
        Console.WriteLine("Person");
    }
}
class Chef : Person, Worker
{
    public string Specialty;
    public Chef(string name, int id, string specialty) : base(name, id)
    {
        Specialty = specialty;
    }
    public override void DisplayRole()
    {
        Console.WriteLine("Chef");
    }
    public void PerformDuties()
    {
        Console.WriteLine("Preparing dishes");
    }
}
class Waiter : Person, Worker
{
    public int TablesAssigned;
    public Waiter(string name, int id, int tablesAssigned) : base(name, id)
    {
        TablesAssigned = tablesAssigned;
    }
    public override void DisplayRole()
    {
        Console.WriteLine("Waiter");
    }
    public void PerformDuties()
    {
        Console.WriteLine("Serving customers");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Chef c = new Chef("Alice", 101, "Italian Cuisine");
        Waiter w = new Waiter("Bob", 102, 5);
        c.DisplayRole();
        c.PerformDuties();
        w.DisplayRole();
        w.PerformDuties();
    }
}