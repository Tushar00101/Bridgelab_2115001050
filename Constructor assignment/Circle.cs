using System;

class Circle
{
    private double radius;

    public Circle() : this(1.0) 
    {

    }

    public Circle(double radius)
    {

        this.radius = radius;

    }

    public double Area()
    {

        return Math.PI * radius * radius;

    }

    public void CircleInfo()
    {
        Console.WriteLine("Radius: " + radius);

        Console.WriteLine("Area: " + Area());
    }

    static void Main(string[] args)
    {
        Circle circle1 = new Circle();
        Console.WriteLine("Circle 1 (Default Radius):");
        circle1.CircleInfo();
        Console.WriteLine("\nEnter radius for Circle 2:");
        double raduis = double.Parse(Console.ReadLine());
        Circle circle2 = new Circle(raduis);
        Console.WriteLine("\nCircle 2:");
        circle2.CircleInfo();
    }
}