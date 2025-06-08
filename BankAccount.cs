using System;

public class BankAccount
{
    private decimal balance;
    public event Action<decimal> BalanceChangedDeposit;
    public event Action<decimal> BalanceChangedWithdraw;
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            BalanceChangedDeposit?.Invoke(balance);
        }
    }
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            BalanceChangedWithdraw?.Invoke(balance);
        }
    }
}
