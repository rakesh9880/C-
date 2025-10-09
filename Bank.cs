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


// using System;

// class InsufficientBalanceException : Exception
// {
//     public InsufficientBalanceException(string message) : base(message) { }
// }

// class BankAccount
// {
//     public decimal Balance;

//     public BankAccount(decimal balance)
//     {
//         Balance = balance;
//     }

//     public void Deposit(decimal amount)
//     {
//         if (amount > 0)
//             Balance += amount;
//         else
//             Console.WriteLine("Deposit amount must be positive.");
//     }

//     public void Withdraw(decimal amount)
//     {
//         if (amount > Balance)
//             throw new InsufficientBalanceException("Not enough money.");
//         Balance -= amount;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         BankAccount account = new BankAccount(500);

//         while (true)
//         {
//             Console.WriteLine("\nChoose an option:");
//             Console.WriteLine("1. Deposit");
//             Console.WriteLine("2. Withdraw");
//             Console.WriteLine("3. Show Balance");
//             Console.WriteLine("4. Exit");
//             Console.Write("Your choice: ");

//             string choice = Console.ReadLine();

//             switch (choice)
//             {
//                 case "1":
//                     Console.Write("Enter deposit amount: ");
//                     if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
//                     {
//                         account.Deposit(depositAmount);
//                         Console.WriteLine("Deposit successful.");
//                         Console.WriteLine("New balance: " + account.Balance);
//                     }
//                     else
//                     {
//                         Console.WriteLine("Invalid input.");
//                     }
//                     break;

//                 case "2":
//                     Console.Write("Enter withdraw amount: ");
//                     try
//                     {
//                         decimal withdrawAmount = decimal.Parse(Console.ReadLine());
//                         account.Withdraw(withdrawAmount);
//                         Console.WriteLine("Withdrawal successful.");
//                         Console.WriteLine("New balance: " + account.Balance);
//                     }
//                     catch (InsufficientBalanceException ex)
//                     {
//                         Console.WriteLine(ex.Message);
//                     }
//                     catch
//                     {
//                         Console.WriteLine("Invalid input.");
//                     }
//                     break;

//                 case "3":
//                     Console.WriteLine("Current balance: " + account.Balance);
//                     break;

//                 case "4":
//                     Console.WriteLine("Goodbye!");
//                     return;

//                 default:
//                     Console.WriteLine("Invalid choice. Try again.");
//                     break;
//             }
//         }
//     }
// }

