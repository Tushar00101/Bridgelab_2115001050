using System;
class Vehicle
{
    public int MaxSpeed;
    public string FuelType;
    public Vehicle(int maxSpeed, string fuelType)
    {
        MaxSpeed = maxSpeed;
        FuelType = fuelType;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Max Speed: {MaxSpeed}, Fuel Type: {FuelType}");
    }
}
class Car : Vehicle
{
    public int SeatCapacity;
    public Car(int maxSpeed, string fuelType, int seatCapacity) : base(maxSpeed, fuelType)
    {
        SeatCapacity = seatCapacity;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Max Speed: {MaxSpeed}, Fuel Type: {FuelType}, Seat Capacity: {SeatCapacity}");
    }
}
class Truck : Vehicle
{
    public int PayloadCapacity;
    public Truck(int maxSpeed, string fuelType, int payloadCapacity) : base(maxSpeed, fuelType)
    {
        PayloadCapacity = payloadCapacity;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Max Speed: {MaxSpeed}, Fuel Type: {FuelType}, Payload Capacity: {PayloadCapacity}");
    }
}
class Motorcycle : Vehicle
{
    public bool HasSidecar;
    public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar) : base(maxSpeed, fuelType)
    {
        HasSidecar = hasSidecar;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Max Speed: {MaxSpeed}, Fuel Type: {FuelType}, Has Sidecar: {HasSidecar}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Vehicle[] vehicles = {
            new Car(200, "Petrol", 5),
            new Truck(120, "Diesel", 10000),
            new Motorcycle(180, "Petrol", false)
        };
        foreach (Vehicle v in vehicles)
        {
            v.DisplayInfo();
        }
    }
}