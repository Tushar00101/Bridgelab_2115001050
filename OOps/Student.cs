using System;

class Student
{
    private static string UniversityName = "Global University";

    private static int totalStudents = 0;

    private readonly int RollNumber;
    private string Name;

    private string Grade;

    public Student(string Name, int RollNumber, string Grade)
    {

        this.Name = Name;

        this.RollNumber = RollNumber;

        this.Grade = Grade;

        totalStudents++;
    }

    public void Display()
    {
        if (this is Student)
        {

            Console.WriteLine("University: " + UniversityName);

            Console.WriteLine("Name: " + Name);

            Console.WriteLine("Roll Number: " + RollNumber);

            Console.WriteLine("Grade: " + Grade);

        }
    }

    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students: " + totalStudents);
    }

    static void Main(string[] args)
    {
        Student stu1 = new Student("Xane", 101, "A");

        Student stu2 = new Student("Bobby", 102, "B");

        stu1.Display();

        stu2.Display();

        Student.DisplayTotalStudents();
    }
}
