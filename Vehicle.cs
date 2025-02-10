using System;
using System.Collections.Generic;

abstract class Vehicle
{
    protected string vehNum;
    
    protected string type;
    
    protected double rentRate;

    public string VehNum { get { return vehNum; } set { vehNum = value; } }
    
    public string Type { get { return type; } set { type = value; } }
    
    public double RentRate { get { return rentRate; } set { rentRate = value; } }

    public Vehicle(string num, string tp, double rate)
    {
        vehNum = num;
        
        type = tp;
        
        rentRate = rate;
    }

    public abstract double CalcRent(int days);
}

interface IInsurable
{
    double CalcIns();
    
    string GetInsDet();
}

class Car : Vehicle, IInsurable
{
    public Car(string num, double rate) : base(num, "Car", rate) { }

    public override double CalcRent(int days)
    {
        return rentRate * days;
    }

    public double CalcIns()
    {
        return rentRate * 0.1;
    }

    public string GetInsDet()
    {
        return "Car Insurance: 10%";
    }
}

class Bike : Vehicle
{
    public Bike(string num, double rate) : base(num, "Bike", rate) { }

    public override double CalcRent(int days)
    {
        return rentRate * days * 0.9;
    }
}

class Truck : Vehicle, IInsurable
{
    public Truck(string num, double rate) : base(num, "Truck", rate) { }

    public override double CalcRent(int days)
    {
        return rentRate * days * 1.2;
    }

    public double CalcIns()
    {
        return rentRate * 0.15;
    }

    public string GetInsDet()
    {
        return "Truck Insurance: 15%";
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehs = new List<Vehicle>();
        
        vehs.Add(new Car("C123", 50));
        
        vehs.Add(new Bike("B456", 20));
        
        vehs.Add(new Truck("T789", 100));

        foreach (Vehicle veh in vehs)
        {
            double finalCost = veh.CalcRent(5) + (veh is IInsurable ins ? ins.CalcIns() : 0);
            
            Console.WriteLine("Number: " + veh.VehNum + ", Type: " + veh.Type + ", Final Cost: " + finalCost);
        }
    }
}

