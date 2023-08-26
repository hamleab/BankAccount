using Classes;

public class Program
{
    private static void Main(string[] args)
    {
        var account = new BankAccount("Abel Mengistu", 1200);
        Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
        account.Withdraw(1000, DateTime.Now, "Rent payment");
        Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
        account.Deposit(500, DateTime.Now, "Friend paid me back");
        Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

        Console.WriteLine(account.GetAccountHistory());
      
        // BankAccount invalidAccount;
        // try
        // {
        //     invalidAccount = new BankAccount("invalid", -55);
        // }
        // catch (ArgumentOutOfRangeException e)
        // {
        //     Console.WriteLine("Exception caught creating account with negative balance");
        //     Console.WriteLine(e.ToString());
        //     return;
        // }

        // Test for a negative balance.
        // try
        // {
        //     account.Withdraw(750, DateTime.Now, "Attempt to overdraw");
        // }
        // catch (InvalidOperationException e)
        // {
        //     Console.WriteLine("Exception caught trying to overdraw");
        //     Console.WriteLine(e.ToString());
        // }

        
    }
}