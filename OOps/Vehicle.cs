using System;

class Vehicle
{
    private static double RegistrationFee = 500.0;
    private readonly int RegistrationNumber;

    private string OwnerName;

    private string VehicleType;

    public Vehicle(string OwnerName, int RegistrationNumber, string VehicleType)
    {

        this.OwnerName = OwnerName;

        this.RegistrationNumber = RegistrationNumber;
        this.VehicleType = VehicleType;

    }

    public void Display()
    {
        if (this is Vehicle)
        {
            Console.WriteLine("Owner: " + OwnerName);

            Console.WriteLine("Registration Number: " + RegistrationNumber);
            Console.WriteLine("Vehicle Type: " + VehicleType);

            Console.WriteLine("Registration Fee: " + RegistrationFee);
        }
    }

    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
    }

    static void Main(string[] args)
    {
        Vehicle veh1 = new Vehicle("Alice", 1001, "Car");

        Vehicle veh2 = new Vehicle("Bob", 1002, "Motorcycle");


        veh1.Display();
        veh2.Display();
        Vehicle.UpdateRegistrationFee(600.0);

        Console.WriteLine("Updated Registration Fee:");

        veh1.Display();

        veh2.Display();
    }
}