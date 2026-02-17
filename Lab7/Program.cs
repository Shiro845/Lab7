public class BankTerminal
{
    public event Action<int> OnMoneyWithDraw;

    public void WithDraw(int amount)
    {
        Console.WriteLine($"Зачислення {amount} грн.....\n");
        OnMoneyWithDraw.Invoke(amount);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        BankTerminal terminal = new BankTerminal();
        terminal.OnMoneyWithDraw += amount => Console.WriteLine($"На ваш рахунок начислено {amount} грн.");
        //terminal.OnMoneyWithDraw = null;
        terminal.WithDraw(100);
    }
}