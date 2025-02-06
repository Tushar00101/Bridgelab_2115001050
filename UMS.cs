using System;
using System.Collections.Generic;

class Course
{
    public string Name { get; }
    private List<Student> students;
    private Professor professor;

    public Course(string name)
    {
        Name = name;

        students = new List<Student>();
    }

    public void AssignProfessor(Professor prof)
    {
        professor = prof;

        Console.WriteLine("Professor " + prof.Name + " assigned to " + Name);
    }

    public void EnrollStudent(Student stu)
    {
        students.Add(stu);

        stu.AddCourse(this);

        Console.WriteLine(stu.Name + " enrolled in " + Name);
    }

    public void Show()
    {
        Console.WriteLine("Course: " + Name);
        if (professor != null)
        {
            Console.WriteLine("  Professor: " + professor.Name);
        }
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

class Professor
{
    public string Name { get; }

    public Professor(string name)
    {
        Name = name;
    }

    public void Show()
    {
        Console.WriteLine("Professor: " + Name);
    }
}

class University
{
    public string Name { get; }
    private List<Course> courses;
    private List<Student> students;
    private List<Professor> professors;

    public University(string name)
    {
        Name = name;
        courses = new List<Course>();

        students = new List<Student>();

        professors = new List<Professor>();
    }

    public void AddCourse(Course crs)
    {
        courses.Add(crs);
    }

    public void AddStudent(Student stu)
    {
        students.Add(stu);
    }

    public void AddProfessor(Professor prof)
    {
        professors.Add(prof);
    }

    public void Show()
    {
        Console.WriteLine("University: " + Name);

        foreach (var crs in courses)
        {
            crs.Show();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        University u1 = new University("IIT Bombay");

        Student s1 = new Student("Rohan Mehta");

        Student s2 = new Student("Ananya Sharma");

        Professor p1 = new Professor("Dr. Arvind Kumar");

        Professor p2 = new Professor("Dr. Priya Verma");

        Course c1 = new Course("Data Structures");

        Course c2 = new Course("Machine Learning");

        c1.AssignProfessor(p1);

        c2.AssignProfessor(p2);

        c1.EnrollStudent(s1);

        c1.EnrollStudent(s2);

        c2.EnrollStudent(s1);

        u1.AddCourse(c1);

        u1.AddCourse(c2);

        u1.AddStudent(s1);

        u1.AddStudent(s2);

        u1.AddProfessor(p1);

        u1.AddProfessor(p2);

        Console.WriteLine();
        u1.Show();
    }
