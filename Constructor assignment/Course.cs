using System;

class Course
{
    string courseName;
    int duration; 

    double fee;


    static string instituteName = "Default Institute";

    public Course(string name, int dur, double courseFee)
    {
        courseName = name;

        duration = dur;

        fee = courseFee;
    }
    public void Details()
    {
        Console.WriteLine("Course Name: " + courseName);

        Console.WriteLine("Duration: " + duration + " hours");

        Console.WriteLine("Fee: $" + fee);

        Console.WriteLine("Institute: " + instituteName);
    }

    public static void UpdateName(string newInstituteName)
    {

        instituteName = newInstituteName;
    }

    static void Main()
    {
        Console.WriteLine("Enter details for Course 1:");
        Console.Write("Course Name: ");
        string course1Name = Console.ReadLine();
        Console.Write("Duration (hours): ");
        int course1Duration = int.Parse(Console.ReadLine());
        Console.Write("Fee: ");

        double course1Fee = double.Parse(Console.ReadLine());

        Course course1 = new Course(course1Name, course1Duration, course1Fee);

        Console.WriteLine("\nEnter details for Course 2:");
        Console.Write("Course Name: ");
        string course2Name = Console.ReadLine();
        Console.Write("Duration (hours): ");
        int course2Duration = int.Parse(Console.ReadLine());
        Console.Write("Fee: ");
        
        double course2Fee = double.Parse(Console.ReadLine());

        Course course2 = new Course(course2Name, course2Duration, course2Fee);
        Console.WriteLine("\nCourse 1 Details:");
        course1.Details();
        Console.WriteLine("\nCourse 2 Details:");
        course2.Details();
        Console.WriteLine("\nEnter a new institute name: ");
        string newInstituteName = Console.ReadLine();

        Course.UpdateName(newInstituteName);

        
        Console.WriteLine("\nUpdated Course 1 Details:");
        
        course1.Details();
        Console.WriteLine("\nUpdated Course 2 Details:");
        course2.Details();
    }
}
