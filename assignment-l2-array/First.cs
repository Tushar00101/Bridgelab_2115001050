using System;

class Program
{
    static void Main()
    {
        double[] salary = new double[10];
        double[] yearsOfService = new double[10];
        double[] bonus = new double[10];
        double[] newSalary = new double[10];
        double totalBonus = 0, totalOldSalary = 0, totalNewSalary = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter salary for employee " + (i + 1) + ":");
            double inputSalary = Convert.ToDouble(Console.ReadLine());
            if (inputSalary <= 0)
            {
                Console.WriteLine("Invalid salary. Enter again.");
                i--;
                continue;
            }

            Console.WriteLine("Enter years of service for employee " + (i + 1) + ":");
            double inputYears = Convert.ToDouble(Console.ReadLine());
            if (inputYears < 0)
            {
                Console.WriteLine("Invalid years of service. Enter again.");
                i--;
                continue;
            }

            salary[i] = inputSalary;
            yearsOfService[i] = inputYears;
        }

        for (int i = 0; i < 10; i++)
        {
            if (yearsOfService[i] > 5)
                bonus[i] = salary[i] * 0.05;
            else
                bonus[i] = salary[i] * 0.02;

            newSalary[i] = salary[i] + bonus[i];
            totalBonus += bonus[i];
            totalOldSalary += salary[i];
            totalNewSalary += newSalary[i];
        }

        Console.WriteLine("Total Bonus Payout: " + totalBonus);
        Console.WriteLine("Total Old Salary: " + totalOldSalary);
        Console.WriteLine("Total New Salary: " + totalNewSalary);
    }
}
