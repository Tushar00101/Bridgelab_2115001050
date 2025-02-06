using System;
using System.Collections.Generic;

class Faculty
{
    public string Name { get; }

    public Faculty(string name)
    {
        Name = name;
    }

    public void Show()
    {
        Console.WriteLine("  Faculty: " + Name);
    }
}

class Department
{
    public string Name { get; }
    private List<Faculty> faculties;

    public Department(string name)
    {
        Name = name;

        faculties = new List<Faculty>();
    }

    public void Add(Faculty fac)
    {
        faculties.Add(fac);
    }

    public void Show()
    {
        Console.WriteLine(" Department: " + Name);

        foreach (var fac in faculties)
        {
            fac.Show();
        }
    }
}

class University
{
    public string Name { get; }
    private List<Department> departments;

    public University(string name)
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
        Console.WriteLine("University: " + Name);

        foreach (var dept in departments)
        {
            dept.Show();
        }
    }

    ~University()
    {
        Console.WriteLine("University " + Name + " is deleted. All departments are removed.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        University u1 = new University("Indian Institute of Science");

        Department d1 = new Department("Computer Science");

        Department d2 = new Department("Mechanical Engineering");

        Faculty f1 = new Faculty("Dr. A. Kumar");

        Faculty f2 = new Faculty("Dr. P. Sharma");

        d1.Add(f1);

        d2.Add(f2);

        u1.Add(d1);

        u1.Add(d2);

        u1.Show();
    }
}