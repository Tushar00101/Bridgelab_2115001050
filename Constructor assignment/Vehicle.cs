using System;

class Vehicle
{
    
    string owner;
    string type;

    static double regFee = 100.0;


    public Vehicle(string ownerName, string vehicleType)
    {
        owner = ownerName;

        type = vehicleType;
    }
    public void Details()
    {
        Console.WriteLine("Owner: " + owner);

        Console.WriteLine("Vehicle Type: " + type);

        Console.WriteLine("Registration Fee: $" + regFee);
    }

    public static void Update(double newFee)
    {
        regFee = newFee;

    }

    static void Main()
    {
        
        Console.WriteLine("Enter details for Vehicle 1:");
        Console.Write("Owner Name: ");
        string owner1 = Console.ReadLine();
        Console.Write("Vehicle Type: ");
        string type1 = Console.ReadLine();
        Vehicle v1 = new Vehicle(owner1, type1);
        Console.WriteLine("\nEnter details for Vehicle 2:");
        Console.Write("Owner Name: ");
        string owner2 = Console.ReadLine();
        Console.Write("Vehicle Type: ");
        string type2 = Console.ReadLine();

        Vehicle v2 = new Vehicle(owner2, type2);
        Console.WriteLine("\nVehicle 1 Details:");
        v1.Details();

        Console.WriteLine("\nVehicle 2 Details:");
        v2.Details();
        Console.WriteLine("\nEnter a new registration fee: ");
        double newFee = double.Parse(Console.ReadLine());
        Vehicle.Update(newFee);

   
        Console.WriteLine("\nUpdated Vehicle 1 Details:");
        v1.Details();

        Console.WriteLine("\nUpdated Vehicle 2 Details:");
        v2.Details();
    }
}