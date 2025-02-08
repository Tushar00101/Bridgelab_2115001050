using System;
class Person
{
    public string Name;
    public int Age;
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public virtual void DisplayRole()
    {
        Console.WriteLine("Person");
    }
}
class Teacher : Person
{
    public string Subject;
    public Teacher(string name, int age, string subject) : base(name, age)
    {
        Subject = subject;
    }
    public override void DisplayRole()
    {
        Console.WriteLine("Teacher");
    }
}
class Student : Person
{
    public int Grade;
    public Student(string name, int age, int grade) : base(name, age)
    {
        Grade = grade;
    }
    public override void DisplayRole()
    {
        Console.WriteLine("Student");
    }
}
class Staff : Person
{
    public string Department;
    public Staff(string name, int age, string department) : base(name, age)
    {
        Department = department;
    }
    public override void DisplayRole()
    {
        Console.WriteLine("Staff");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Teacher t = new Teacher("Akash", 35, "Math");
        Student s = new Student("Bobby", 16, 10);
        Staff st = new Staff("Charls", 40, "Administration");
        t.DisplayRole();
        s.DisplayRole();
        st.DisplayRole();
    }
}
