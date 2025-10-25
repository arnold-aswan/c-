namespace BankSystem;

public class Account
{
    public string Owner { get; }
    private decimal Balance { get; set; }
    private static int _accountCounter = 0;

    public Account(string owner, decimal deposit = 0.00m)
    {
        Owner = owner;
        Balance = deposit;
        _accountCounter++;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive.");
            return;
        }
        Balance += amount;
        Console.WriteLine($"{amount} has been successfully deposited to your account.");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be positive.");
            return;
        }
        if (Balance < amount)
        {
            Console.WriteLine(
                $"You have insufficient funds to complete your withdraw of {amount}. Current balance is  {Balance}");
            return;
        }
        Balance -= amount;
        Console.WriteLine($"You have successfully Withdrawn {amount}. Current balance is  {Balance}");
    }

    public void Transfer(Account account, decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Transfer amount must be positive.");
            return;
        }
        
        if (Balance < amount)
        {
            Console.WriteLine(
                $"You have insufficient funds to complete your request. Current balance is {Balance}");
            return;
        }
        Balance -= amount;
        account.Deposit(amount);
        Console.WriteLine($"Transferred ${amount:F2} to {account.Owner}. Your new balance: ${Balance:F2}");
    }
    public void PrintBalance() => Console.WriteLine($"Your balance is {Balance}");
    public static void GetTotalAccounts() => Console.WriteLine($"There are {_accountCounter} total accounts.");
}