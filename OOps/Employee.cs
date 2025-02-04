using System;

class Employee
{
    private static string CompanyName = "Tech Corp";

    private static int totalEmployees = 0;
    private readonly int Id;

    private string Name;
    private string Designation;

    public Employee(string Name, int Id, string Designation)

    {
        this.Name = Name;
        this.Id = Id;

        this.Designation = Designation;

        totalEmployees++;
    }

    public void Display()
    {
        if (this is Employee)
        {
            Console.WriteLine("Company: " + CompanyName);

            Console.WriteLine("Name: " + Name);

            Console.WriteLine("ID: " + Id);

            Console.WriteLine("Designation: " + Designation);
        }
    }

    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees: " + totalEmployees);
    }

    static void Main(string[] args)
    {
        Employee emp1 = new Employee("Kangroo", 101, "Manager");

        Employee emp2 = new Employee("Bobby", 102, "Developer");

        emp1.Display();

        emp2.Display();

        Employee.DisplayTotalEmployees();
    }
}

