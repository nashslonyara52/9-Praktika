using System;
internal class BankAccount
{
    public string Owner;
    public double Balance;
    public BankAccount(string owner, double Balancer)
    {
        Owner = owner;
        if (Balancer >= 0)
            Balance = Balancer;
        else
            Balance = 0;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine(Owner + ", баланс: " + Balance + ".");
        }
    }
    public void Withdraw(double amount)
    {
        if (amount > 0)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine(Owner + ", баланс: " + Balance + ".");
            }
            else
            {
                Console.WriteLine("Недостаточно средств!");
                Console.WriteLine(Owner + ", баланс: " + Balance + ".");
            }
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("МегаМакс", 1000);
        account.Deposit(500);
        account.Withdraw(500);
        account.Withdraw(5200); 
    }
}