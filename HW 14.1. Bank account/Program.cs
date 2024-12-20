using System;
class Account
{
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
}
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
