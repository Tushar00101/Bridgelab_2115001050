using System;

class BankAccount
{
    public string accountNumber;
    protected string accountHolder;
    private double balance;

    public BankAccount(string accNumber, string holder, double initialBalance)
    {
        accountNumber = accNumber;
        
        accountHolder = holder;
        
        balance = initialBalance;
    }

    public double GetBalance()
    {
        return balance;
    }

    public void SetBalance(double amount)
    {
        if (amount >= 0)
        {
            balance = amount;
        }
        else
        {
            Console.WriteLine("Invalid balance amount.");
        }
    }
    

    public void Display()
    {
        Console.WriteLine("Account Number: " + accountNumber);

        Console.WriteLine("Account Holder: " + accountHolder);

        Console.WriteLine("Balance: $" + balance);
    }
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(string accNumber, string holder, double initialBalance)
        : base(accNumber, holder, initialBalance)
    {
    }

    public void DisplaySavingsAccount()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        
        Console.WriteLine("Account Holder: " + accountHolder);
        
        Console.WriteLine("Balance: $" + GetBalance());

    }
}

class Program
{
    static void Main()
    {
        BankAccount account1 = new BankAccount("123456789", "Alice", 5000.0);

        account1.Display();
        account1.SetBalance(5500.0);
        Console.WriteLine("\nUpdated Account Details:");
        account1.Display();
        SavingsAccount savingsAccount = new SavingsAccount("987654321", "Bob", 10000.0);
        Console.WriteLine("\nSavings Account Details:");

        savingsAccount.DisplaySavingsAccount();
    }
}