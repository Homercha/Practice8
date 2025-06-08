using System;

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        AccountMonitor monitor = new AccountMonitor();
        account.BalanceChangedDeposit += monitor.OnBalanceChanged;
        account.BalanceChangedWithdraw += monitor.OnBalanceChanged;
        account.Deposit(500);
        account.Withdraw(150);
        account.Deposit(300);
        account.Withdraw(1000);

        Console.ReadLine();
    }
}
