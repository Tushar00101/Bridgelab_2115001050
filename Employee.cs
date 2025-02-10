using System;
using System.Collections.Generic;

abstract class Employee
{
    protected int empId;

    protected string name;

    protected double baseSal;

    public int EmpId { get { return empId; } set { empId = value; } }

    public string Name { get { return name; } set { name = value; } }

    public double BaseSal { get { return baseSal; } set { baseSal = value; } }

    public Employee(int id, string nm, double sal)
    {
        empId = id;

        name = nm;

        baseSal = sal;
    }

    public abstract double CalcSal();

    public void Display()
    {
        Console.WriteLine("ID: " + empId + ", Name: " + name + ", Salary: " + CalcSal());
    }
}

interface IDepartment
{
    void AssignDept(string dept);
    string GetDept();
}

class FullTimeEmp : Employee, IDepartment
{
    private string dept;

    public FullTimeEmp(int id, string nm, double sal) : base(id, nm, sal) { }

    public override double CalcSal()
    {
        return baseSal;
    }

    public void AssignDept(string d)
    {
        dept = d;
    }

    public string GetDept()
    {
        return dept;
    }
}

class PartTimeEmp : Employee, IDepartment
{
    private string dept;

    private int hours;

    private double rate;

    public PartTimeEmp(int id, string nm, double r, int h) : base(id, nm, 0)
    {
        rate = r;
        hours = h;
    }

    public override double CalcSal()
    {
        return rate * hours;
    }

    public void AssignDept(string d)
    {
        dept = d;
    }

    public string GetDept()
    {
        return dept;
    }
}

class Program
{
    static void Main()
    {
        List<Employee> emps = new List<Employee>();

        emps.Add(new FullTimeEmp(1, "Ram", 5000));

        emps.Add(new PartTimeEmp(2, "Imran", 20, 100));

        foreach (Employee emp in emps)
        {
            emp.Display();
        }
    }
}
