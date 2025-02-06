using System;
using System.Collections.Generic;

class Bank
{
    public string Name { get; }

    public Bank(string name)
    {
        Name = name;
    }

    public void OpenAccount(Customer cust, string accNo, double bal)
    {
        Account acc = new Account(accNo, bal, this);

        cust.AddAccount(acc);
    }

    public void Show()
    {
        Console.WriteLine("Bank: " + Name);
    }
}

class Customer
{
    public string Name { get; }

    private List<Account> accounts;

    public Customer(string name)
    {
        Name = name;

        accounts = new List<Account>();
    }

    public void AddAccount(Account acc)
    {
        accounts.Add(acc);
    }

    public void ViewBalance()
    {
        Console.WriteLine("Customer: " + Name);

        foreach (var acc in accounts)
        {
            acc.Show();
        }
    }
}

class Account
{
    public string Number { get; }

    private double Balance;

    private Bank Bank;

    public Account(string number, double balance, Bank bank)
    {
        Number = number;

        Balance = balance;

        Bank = bank;
    }

    public void Show()
    {
        Console.WriteLine("Account: " + Number + ", Balance: ₹" + Balance);

        Bank.Show();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bank b1 = new Bank("State Bank of India");

        Bank b2 = new Bank("HDFC Bank");

        Customer c1 = new Customer("Rajesh Kumar");

        Customer c2 = new Customer("Priya Sharma");

        b1.OpenAccount(c1, "SBI123", 50000);

        b2.OpenAccount(c2, "HDFC456", 75000);

        b1.OpenAccount(c1, "SBI789", 30000);

        c1.ViewBalance();

        Console.WriteLine();

        c2.ViewBalance();
    }
}