using System;
class Date{
    static void Main(string[] args){
        Console.Write("Enter a Date in (yyyy-MM-dd): ");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());


        DateTime date = inputDate.AddDays(7).AddMonths(1).AddYears(2);

        Console.WriteLine("Adding 7 days, 1 month, and 2 years: " + date.ToString("yyyy-MM-dd"));

        DateTime endDate = date.AddDays(-21);

        Console.WriteLine("subtracting 3 weeks: " + endDate.ToString("yyyy-MM-dd"));


    }
}