public class TransactionManager
{
    public static void PerformWithdraw(BankAccount bankAccount, int withdrawOption)
    {
        if (bankAccount.Withdraw(withdrawOption))
        {
            Console.WriteLine("Withdraw success");
        }
        else
        {
            Console.WriteLine("Withdraw failed. Check balance and try again.");
        }
    }

    public static void PerformDeposit(BankAccount bankAccount, int depositOption)
    {
        bankAccount.Deposit(depositOption);
        Console.WriteLine("Deposit success");
    }
}
