using System;
using System.Collections.Generic;

abstract class BankAccount
{
    protected string accNum;
    
    protected string holder;
    
    protected double balance;

    public string AccNum { get { return accNum; } set { accNum = value; } }
    
    public string Holder { get { return holder; } set { holder = value; } }
    
    public double Balance { get { return balance; } protected set { balance = value; } }

    public BankAccount(string num, string hld, double bal)
    {
        accNum = num;
        holder = hld;
        balance = bal;
    }

    public void Deposit(double amt)
    {
        balance += amt;
    }

    public virtual void Withdraw(double amt)
    {
        if (amt <= balance)
        
            balance -= amt;
        else
            Console.WriteLine("Insufficient funds");
    }

    public abstract double CalcInt();
}

interface ILoanable
{
    void ApplyLoan(double amt);
    
    bool CalcLoanElig();
}

class SavingsAcc : BankAccount, ILoanable
{
    public SavingsAcc(string num, string hld, double bal) : base(num, hld, bal) { }

    public override double CalcInt()
    {
        return balance * 0.04;
    }

    public void ApplyLoan(double amt)
    {
        Console.WriteLine("Loan applied for: " + amt);
    }

    public bool CalcLoanElig()
    {
        return balance > 5000;
    }
}

class CurrentAcc : BankAccount
{
    public CurrentAcc(string num, string hld, double bal) : base(num, hld, bal) { }

    public override double CalcInt()
    {
        return balance * 0.02;
    }
}

class Program
{
    static void Main()
    {
        List<BankAccount> accts = new List<BankAccount>();
        
        accts.Add(new SavingsAcc("S123", "Ram", 6000));
        
        accts.Add(new CurrentAcc("C456", "Bobby", 3000));
        

        foreach (BankAccount acct in accts)
        {
            Console.WriteLine("Account: " + acct.AccNum + ", Holder: " + acct.Holder + ", Interest: " + acct.CalcInt());
        }
    }
}
