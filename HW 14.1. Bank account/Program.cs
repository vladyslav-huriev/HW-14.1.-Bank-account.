using System;
class Account
{
    private string _name;
    private double _balance;
    public string Name
    {
        get => _name;
        private set => _name = value;
        // private set => _name = value;
    }
    public double Balance
    {
        get => _balance;
        private set => _balance = value < 0 ? 0 : value;
    }
    public Account(string name, double initialBalance)
    {
        Name = name;
        Balance = initialBalance;
    }
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    public void Withdrawal(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
        }
    }
}
/*{
    public string Name {get;}
    private double _balance;
    public double Balance => _balance;
    public Account(string name, double initialBalance)
    {
        Name = name;
        _balance = initialBalance < 0 ? 0 : initialBalance;
    }
    public void Deposit(double amount) => _balance += amount > 0 ? amount : 0;
    public void Withdrawal(double amount)
        => _balance -= amount > 0 && amount <= _balance ? amount : 0;
}*/

class Program
{
    static void Main()
    {
        Account vladAccount = new Account("Vlad's account", 100);
        Account vladPlAccount = new Account("Vlad's account in Poland", 1000000);
        vladAccount.Withdrawal(20);
        Console.WriteLine($"The balance of Vlad's account is now: {vladAccount.Balance}");
        vladPlAccount.Deposit(200);
        Console.WriteLine($"The balance of Vlad's other account is now: {vladPlAccount.Balance}");
    }
}
