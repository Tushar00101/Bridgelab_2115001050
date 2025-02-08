using System;

class Animal
{
    public string Name;

    public int Age;
    public Animal(string name, int age)
    {
        Name = name;

        Age = age;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}
class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}
class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}
class Bird : Animal
{
    public Bird(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Bird chirps");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Dog d = new Dog("Tommy", 3);

        Cat c = new Cat("Kitty", 2);

        Bird b = new Bird("Tweety", 1);

        d.MakeSound();

        c.MakeSound();

        b.MakeSound();
    }
}
