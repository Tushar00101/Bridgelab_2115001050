using System;

class Employee
{
    public int employeeID;
    protected string department;
    private double salary;

    public Employee(int id, string dept, double initialSalary)
    {
        employeeID = id;
        
        department = dept;
        
        salary = initialSalary;
    }

    public double GetSalary()
    {
        return salary;
    }

    public void SetSalary(double newSalary)
    {
        if (newSalary >= 0)
        {
            salary = newSalary;
        }
        else
        {
            Console.WriteLine("Invalid salary ");
        }
    }

    public void Display()
    {
        Console.WriteLine("Employee ID: " + employeeID);

        Console.WriteLine("Department: " + department);

        Console.WriteLine("Salary: $" + salary);
    }
}

class Manager : Employee
{
    public Manager(int id, string dept, double initialSalary)
        : base(id, dept, initialSalary)
    {

    }

    public void Details()
    {
        Console.WriteLine("Employee ID: " + employeeID);
        
        Console.WriteLine("Department: " + department);
        
        Console.WriteLine("Salary: $" + GetSalary());
    }
}

class Program
{
    static void Main()
    {
        Employee emp1 = new Employee(101, "HR", 60000);
        emp1.Display();
        emp1.SetSalary(65000);
        Console.WriteLine("\nUpdated Employee Details:");
        emp1.Display();
        Manager mgr1 = new Manager(201, "IT", 90000);
        Console.WriteLine("\nManager Details:");
        
        mgr1.Details();
    }
}
