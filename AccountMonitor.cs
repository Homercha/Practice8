using System;

public class AccountMonitor
{
    public void OnBalanceChanged(decimal newBalance)
    {
        Console.WriteLine($"Новий баланс: {newBalance:C}");
    }
}
