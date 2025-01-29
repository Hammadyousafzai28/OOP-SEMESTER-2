using System;
using System.Collections.Generic;

class ATM
{
    private double _balance;
    private List<string> _transactionHistory;

    
    public ATM(double initialBalance)
    {
        _balance = initialBalance;
        _transactionHistory = new List<string>();
    }

    public void Deposit(double amount)
    {
        _balance += amount;
        _transactionHistory.Add($"Deposit: +{amount}");
        Console.WriteLine($"Deposited: {amount}");
    }

    public void Withdraw(double amount)
    {
        if (amount > _balance)
        {
            Console.WriteLine("Error: Insufficient funds.");
            return;
        }
        _balance -= amount;
        _transactionHistory.Add($"Withdrawal: -{amount}");
        Console.WriteLine($"Withdrawn: {amount}");
    }

    public double CheckBalance()
    {
        return _balance;
    }

    public void TransactionHistory()
    {
        Console.WriteLine("Transaction History:");
        foreach (var transaction in _transactionHistory)
        {
            Console.WriteLine(transaction);
        }
    }
}

class Program
{
    static void Main()
    {
        ATM atm = new ATM(1000);
        Console.WriteLine("Initial Balance: " + atm.CheckBalance());

        atm.Deposit(500);
        atm.Withdraw(200);
        atm.Withdraw(1500); // Should show an error

        Console.WriteLine("Current Balance: " + atm.CheckBalance());
        atm.TransactionHistory();
    }
}