using System;
using System.Collections.Generic;

class Employee

{
    public string Name { get; }

    public Employee(string name)
    {
        Name = name;
    }

    public void Show()
    {
        Console.WriteLine("  Employee: " + Name);
    }
}

class Department
{
    public string Name { get; }
    private List<Employee> employees;

    public Department(string name)
    {
        Name = name;

        employees = new List<Employee>();
    }

    public void Add(Employee emp)
    {
        employees.Add(emp);
    }

    public void Show()
    {
        Console.WriteLine(" Department: " + Name);

        foreach (var emp in employees)
        {
            emp.Show();
        }
    }
}

class Company
{
    public string Name { get; }

    private List<Department> departments;

    public Company(string name)
    {
        Name = name;

        departments = new List<Department>();
    }

    public void Add(Department dept)
    {
        departments.Add(dept);
    }

    public void Show()
    {
        Console.WriteLine("Company: " + Name);

        foreach (var dept in departments)
        {
            dept.Show();
        }
    }

    ~Company()
    {
        Console.WriteLine("Company " + Name + " is deleted. All departments and employees are removed.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Company c1 = new Company("Tata Consultancy Services");

        Department d1 = new Department("IT");

        Department d2 = new Department("HR");

        d1.Add(new Employee("Amit Patel"));

        d1.Add(new Employee("Sneha Verma"));

        d2.Add(new Employee("Rohan Das"));

        c1.Add(d1);

        c1.Add(d2);

        c1.Show();
    }
}