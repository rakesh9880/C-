using System;

// Custom exception for insufficient balance
class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message) { }
}

class BankAccount
{
    public decimal Balance;

    public BankAccount(decimal balance)
    {
        Balance = balance;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            throw new InsufficientBalanceException("Not enough money.");
        }
        Balance -= amount;
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(500);

        Console.Write("Withdraw amount: ");
        try
        {
            decimal amount = decimal.Parse(Console.ReadLine());
            account.Withdraw(amount);
            Console.WriteLine("New balance: " + account.Balance);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch
        {
            Console.WriteLine("Invalid input.");
        }
    }
}
