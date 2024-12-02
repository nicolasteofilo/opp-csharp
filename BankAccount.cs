namespace OPP;

public class BankAccount
{
    private decimal Balance; // private field
    public string Holder { get; private set; }

    public BankAccount(decimal balance, string holder)
    {
        Balance = balance;
        Holder = holder;
    }
    
    public decimal GetBalance() => Balance;
    
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be greater than zero");
        
        Balance += amount;
        Console.WriteLine($"Deposited {amount:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be greater than zero");
        
        Balance -= amount;
        Console.WriteLine($"Withdrawn {amount:C}");
    }
}