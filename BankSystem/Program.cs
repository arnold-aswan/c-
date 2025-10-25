/*
💼 Challenge 9: The Bank System (550 XP)
   Concepts: Encapsulation, validation, properties
   Create:
   Account class with Owner, Balance
   Methods: Deposit(), Withdraw(), and Transfer()
   Ensure:
   No negative balances
   Proper transaction messages   
   🔹 Bonus: Add a static counter to track total number of accounts.
*/
namespace BankSystem;
class Program
{
   static void Main()
   {
      Account account = new Account("john");
      Account account2 = new Account("jane");
      
      account.Deposit(500);
      account.Withdraw(600);
      account.PrintBalance();
      Account.GetTotalAccounts();
      account.Transfer(account2, 600);
      account2.PrintBalance();
      account.PrintBalance();
      
   }
}