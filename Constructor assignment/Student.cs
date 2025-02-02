using System;

class Student
{
    public int rollNumber;
    protected string name;
    private double CGPA;
    public Student(int roll, string studentName, double cgpa)
    {
        rollNumber = roll;
        name = studentName;
        CGPA = cgpa;
    }

    public double GetCGPA()
    {
        return CGPA;
    }
    public void SetCGPA(double cgpa)
    {
        if (cgpa >= 0 && cgpa <= 10)
        {
            CGPA = cgpa;
        }
        else
        {
            Console.WriteLine("Invalid CGPA value.");
        }
    }
    public void Display()
    {
        Console.WriteLine("Roll Number: " + rollNumber);

        Console.WriteLine("Name: " + name);

        Console.WriteLine("CGPA: " + CGPA);
    }
}

class PostStudent : Student
{
   
    public PostStudent(int roll, string studentName, double cgpa)
        : base(roll, studentName, cgpa)
    {
    } 
    public void Display()
    {
        Console.WriteLine("Roll Number: " + rollNumber);

        Console.WriteLine("Name: " + name); 
        
        Console.WriteLine("CGPA: " + GetCGPA());
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student(101, "John Doe", 9.2);
        student1.Display();
        student1.SetCGPA(9.5);
        Console.WriteLine("\nUpdated CGPA:");
        student1.Display();
        PostStudent pgStudent = new PostStudent(201, "Jane Smith", 8.8);
        Console.WriteLine("\nPostgraduate Student Details:");
        pgStudent.Display();
    }
}
