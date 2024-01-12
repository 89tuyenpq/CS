using System;

class Program
{
    static BankAccount bankAccount = new BankAccount();

    static void Main()
    {
        Console.WriteLine("Welcome to Bank Application");

        // Insert card
        bankAccount.CardInserted += OnCardInserted;

        while (true)
        {
            Console.WriteLine("\n1. Insert Card");
            Console.WriteLine("2. Check Balance");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Deposit");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    InsertCard();
                    break;

                case 2:
                    CheckBalance();
                    break;

                case 3:
                    Withdraw();
                    break;

                case 4:
                    Deposit();
                    break;

                case 5:
                    Console.WriteLine("Exiting, Goodbye, See you again");

                    // Noti receive card
                    ReturnCardNotification();

                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid. Please try again.");
                    break;
            }
        }
    }

    static void InsertCard()
    {
        // Insert card
        bankAccount.InsertCard();
    }

    static void CheckBalance()
    {
        if (bankAccount.IsCardInserted())
        {
            Console.WriteLine($"Current Balance: {bankAccount.CheckBalance()}");
        }
        else
        {
            Console.WriteLine("Please insert card");
        }
    }

    static void Withdraw()
    {
        if (bankAccount.IsCardInserted())
        {
            Console.WriteLine("Withdraw Options:");
            Console.WriteLine("1. 500k");
            Console.WriteLine("2. 1000k");
            Console.WriteLine("3. 1500k");

            Console.Write("Select amount: ");
            int withdrawOption = int.Parse(Console.ReadLine());

            TransactionManager.PerformWithdraw(bankAccount, withdrawOption);
        }
        else
        {
            Console.WriteLine("Please insert card");
        }
    }

    static void Deposit()
    {
        if (bankAccount.IsCardInserted())
        {
            Console.WriteLine("Deposit Options:");
            Console.WriteLine("1. 500k");
            Console.WriteLine("2. 1000k");
            Console.WriteLine("3. 1500k");

            Console.Write("Select deposit amount: ");
            int depositOption = int.Parse(Console.ReadLine());

            TransactionManager.PerformDeposit(bankAccount, depositOption);
        }
        else
        {
            Console.WriteLine("Please insert card first.");
        }
    }

    // Noti insert card
    static void OnCardInserted(object sender, EventArgs e)
    {
        Console.WriteLine("Successful");
    }

    // Noti receive card
    static void ReturnCardNotification()
    {
        Console.WriteLine("Receive your card, have a nice day");
    }
}
