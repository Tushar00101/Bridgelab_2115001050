using System;

class Person
{
    private string name;

    private int age;

    public Person()
    {
        name = "Unknown";

        age = 0;
    }

    public Person(string name, int age)
    {
        this.name = name;

        this.age = age;
    }

    //copy constructor
    public Person(Person other)
    {
        this.name = other.name;

        this.age = other.age;
    }

    public void PersonInfo()
    {
        Console.WriteLine("Name: " + name);

        Console.WriteLine("Age: " + age);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter person details: ");
        Console.Write("Name: ");

        string name = Console.ReadLine();
        Console.Write("Age: ");

        int age = int.Parse(Console.ReadLine());
        Person person1 = new Person(name, age);
        Console.WriteLine("Original Person: ");
        person1.PersonInfo();
        Person person2 = new Person(person1);
        Console.WriteLine("\nCopied Person:");

        person2.DisplayPersonInfo();
    }
}
