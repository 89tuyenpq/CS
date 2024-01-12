using System;

public class BankAccount
{
    private bool isCardInserted;
    private double balance;

    // define cardinsert
    public event EventHandler CardInserted;

    public void InsertCard()
    {
        isCardInserted = true;

        OnCardInserted();
    }

    protected virtual void OnCardInserted()
    {
        CardInserted?.Invoke(this, EventArgs.Empty);
    }

    public bool IsCardInserted()
    {
        return isCardInserted;
    }

    public double CheckBalance()
    {
        return balance;
    }

    public bool Withdraw(int withdrawOption)
    {
        double withdrawAmount = GetWithdrawAmount(withdrawOption);
        double discount = withdrawAmount * 0.067;
        if (balance >= withdrawAmount + discount)
        {
            balance -= (withdrawAmount + discount);
            return true;
        }
        return false;
    }

    public void Deposit(int depositOption)
    {
        double depositAmount = GetDepositAmount(depositOption);
        balance += depositAmount;
    }

    private double GetWithdrawAmount(int withdrawOption)
    {
        switch (withdrawOption)
        {
            case 1:
                return 500;
            case 2:
                return 1000;
            case 3:
                return 1500;
            default:
                return 0;
        }
    }

    private double GetDepositAmount(int depositOption)
    {
        switch (depositOption)
        {
            case 1:
                return 500;
            case 2:
                return 1000;
            case 3:
                return 1500;
            default:
                return 0;
        }
    }
}
