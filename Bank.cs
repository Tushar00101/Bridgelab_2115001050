using System;
class BankAccount
{
    public int AccountNumber;
    public double Balance;
    public BankAccount(int accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }
    public virtual void DisplayAccountType()
    {
        Console.WriteLine("Bank Account");
    }
}
class SavingsAccount : BankAccount
{
    public double InterestRate;
    public SavingsAccount(int accountNumber, double balance, double interestRate) : base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }
    public override void DisplayAccountType()
    {
        Console.WriteLine("Savings Account");
    }
}
class CheckingAccount : BankAccount
{
    public double WithdrawalLimit;
    public CheckingAccount(int accountNumber, double balance, double withdrawalLimit) : base(accountNumber, balance)
    {
        WithdrawalLimit = withdrawalLimit;
    }
    public override void DisplayAccountType()
    {
        Console.WriteLine("Checking Account");
    }
}
class FixedDepositAccount : BankAccount
{
    public int DepositTerm;
    public FixedDepositAccount(int accountNumber, double balance, int depositTerm) : base(accountNumber, balance)
    {
        DepositTerm = depositTerm;
    }
    public override void DisplayAccountType()
    {
        Console.WriteLine("Fixed Deposit Account");
    }
}
class Program
{
    static void Main(string[] args)
    {
        SavingsAccount s = new SavingsAccount(101, 5000, 3.5);
        CheckingAccount c = new CheckingAccount(102, 3000, 1000);
        FixedDepositAccount f = new FixedDepositAccount(103, 10000, 12);
        s.DisplayAccountType();
        c.DisplayAccountType();
        f.DisplayAccountType();
    }
}