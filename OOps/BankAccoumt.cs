using System;

class BankAccount
{
    private static string bankName = "National Bank";

    private static int totalAccounts = 0;

    private readonly int accNum;

    private string accHolder;

    public BankAccount(string accHolder, int accNum)

    {
        this.accHolder = accHolder;

        this.accNum = accNum;

        totalAccounts++;
    }

    public void Display()
    {
        if (this is BankAccount)
        {
            Console.WriteLine("Bank: " + bankName);
            
            Console.WriteLine("Holder: " + accHolder);
            
            Console.WriteLine("Account: " + accNum);
        }
    }

    public static void Accounts()
    {
        Console.WriteLine("Total Accounts: " + totalAccounts);
    }

    static void Main(string[] args)
    {
        BankAccount acc1 = new BankAccount("zane", 1001);

        BankAccount acc2 = new BankAccount("malik", 1002);

        acc1.Display();

        acc2.Display();

        BankAccount.Accounts();
    }
}
