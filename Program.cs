namespace OPP
{
    class Program
    {
        private static void Main()
        {
            var bankAccount = new BankAccount(0m, "John Doe");
            bankAccount.Deposit(100);
            Console.WriteLine(bankAccount.GetBalance());
        }
    }
}

