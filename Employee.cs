using System;
class Employee
{
    public string Name;
    public int Id;
    public double Salary;
    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Id: {Id}, Salary: {Salary}");
    }
}
class Manager : Employee
{
    public int TeamSize;
    public Manager(string name, int id, double salary, int teamSize) : base(name, id, salary)
    {
        TeamSize = teamSize;
    }
    public override void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Id: {Id}, Salary: {Salary}, Team Size: {TeamSize}");
    }
}
class Developer : Employee
{
    public string ProgrammingLanguage;
    public Developer(string name, int id, double salary, string programmingLanguage) : base(name, id, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }
    public override void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Id: {Id}, Salary: {Salary}, Programming Language: {ProgrammingLanguage}");
    }
}
class Intern : Employee
{
    public string InternshipDuration;
    public Intern(string name, int id, double salary, string internshipDuration) : base(name, id, salary)
    {
        InternshipDuration = internshipDuration;
    }
    public override void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Id: {Id}, Salary: {Salary}, Internship Duration: {InternshipDuration}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Manager m = new Manager("Alice", 101, 75000, 10);
        Developer d = new Developer("Bob", 102, 60000, "C#");
        Intern i = new Intern("Charlie", 103, 20000, "6 months");
        m.DisplayDetails();
        d.DisplayDetails();
        i.DisplayDetails();
    }
}