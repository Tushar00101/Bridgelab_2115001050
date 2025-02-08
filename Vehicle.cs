using System;
interface Refuelable
{
    void Refuel();
}
class Vehicle
{
    public int MaxSpeed;
    public string Model;
    public Vehicle(int maxSpeed, string model)
    {
        MaxSpeed = maxSpeed;
        Model = model;
    }
    public virtual void DisplayType()
    {
        Console.WriteLine("Vehicle");
    }
}
class ElectricVehicle : Vehicle
{
    public int BatteryCapacity;
    public ElectricVehicle(int maxSpeed, string model, int batteryCapacity) : base(maxSpeed, model)
    {
        BatteryCapacity = batteryCapacity;
    }
    public override void DisplayType()
    {
        Console.WriteLine("Electric Vehicle");
    }
    public void Charge()
    {
        Console.WriteLine("Charging battery");
    }
}
class PetrolVehicle : Vehicle, Refuelable
{
    public int FuelTankCapacity;
    public PetrolVehicle(int maxSpeed, string model, int fuelTankCapacity) : base(maxSpeed, model)
    {
        FuelTankCapacity = fuelTankCapacity;
    }
    public override void DisplayType()
    {
        Console.WriteLine("Petrol Vehicle");
    }
    public void Refuel()
    {
        Console.WriteLine("Refueling petrol tank");
    }
}
class Program
{
    static void Main(string[] args)
    {
        ElectricVehicle e = new ElectricVehicle(150, "Tesla Model 3", 75);
        PetrolVehicle p = new PetrolVehicle(180, "Ford Mustang", 50);
        e.DisplayType();
        e.Charge();
        p.DisplayType();
        p.Refuel();
    }
}