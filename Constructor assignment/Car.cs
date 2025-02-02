using System;

class CarRental
{
    private string customerName;
    private string carModel;
    private int rentalDays;
    private double dailyRate;

    public CarRental()
    {
        customerName = "Unknown";
        
        carModel = "Standard";
        rentalDays = 1;

        dailyRate = 50.0; 
    }

    public CarRental(string customerName, string carModel, int rentalDays, double dailyRate)
    {
        this.customerName = customerName;

        this.carModel = carModel;
        
        this.rentalDays = rentalDays;
        
        this.dailyRate = dailyRate;
    }

    public double CalculateTotalCost()
    {
        return rentalDays * dailyRate;
    }

    public void RentalInfo()
    {
        Console.WriteLine("Customer Name: " + customerName);
        Console.WriteLine("Car Model: " + carModel);

        Console.WriteLine("Rental Days: " + rentalDays);
        Console.WriteLine("Daily Rate: $" + dailyRate);

        Console.WriteLine("Total Cost: $" + CalculateTotalCost());
    }

    static void Main(string[] args)
    {
        CarRental rental1 = new CarRental();
        Console.WriteLine("Default Rental:");
        rental1.RentalInfo();
        Console.WriteLine("\nEnter rental details:");
        Console.Write("Customer Name: ");
        string customerName = Console.ReadLine();
        Console.Write("Car Model: ");
        string carModel = Console.ReadLine();
        Console.Write("Rental Days: ");
        int rentalDays = int.Parse(Console.ReadLine());
        Console.Write("Daily Rate: ");
        double dailyRate = double.Parse(Console.ReadLine());

        CarRental rental2 = new CarRental(customerName, carModel, rentalDays, dailyRate);
        Console.WriteLine("\nCustom Rental:");
        rental2.RentalInfo();
    }
}
