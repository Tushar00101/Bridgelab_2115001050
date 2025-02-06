using System;
using System.Collections.Generic;

class Course
{
    public string Name { get; }

    private List<Student> students;

    public Course(string name)
    {
        Name = name;

        students = new List<Student>();
    }

    public void Enroll(Student stu)
    {
        students.Add(stu);

        stu.AddCourse(this);
    }

    public void Show()
    {
        Console.WriteLine("Course: " + Name);

        foreach (var stu in students)
        {
            Console.WriteLine("  Student: " + stu.Name);
        }
    }
}

class Student
{
    public string Name { get; }

    private List<Course> courses;

    public Student(string name)
    {
        Name = name;

        courses = new List<Course>();
    }

    public void AddCourse(Course crs)
    {
        courses.Add(crs);
    }

    public void Show()
    {
        Console.WriteLine("Student: " + Name);
        foreach (var crs in courses)
        {
            Console.WriteLine("  Enrolled in: " + crs.Name);
        }
    }
}

class School
{
    public string Name { get; }
    private List<Student> students;

    public School(string name)
    {
        Name = name;

        students = new List<Student>();
    }

    public void Add(Student stu)
    {
        students.Add(stu);
    }

    public void Show()
    {
        Console.WriteLine("School: " + Name);

        foreach (var stu in students)
        {
            stu.Show();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        School s1 = new School("Delhi Public School");

        Student st1 = new Student("Aryan Sharma");

        Student st2 = new Student("Neha Verma");

        Course c1 = new Course("Mathematics");

        Course c2 = new Course("Physics");

        c1.Enroll(st1);

        c1.Enroll(st2);

        c2.Enroll(st1);

        s1.Add(st1);

        s1.Add(st2);

        s1.Show();

        Console.WriteLine();

        c1.Show();

        Console.WriteLine();

        c2.Show();
    }
}