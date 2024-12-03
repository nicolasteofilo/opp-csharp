namespace OPP
{
    class Program
    {
        private static void Main()
        {
            var bankAccount = new BankAccount(0m, "John Doe");
            bankAccount.Deposit(100);
            // Console.WriteLine(bankAccount.GetBalance());
            
            var keyboard = new CartItem("Logitech Keyboard", 100.30m);
            Console.WriteLine(CartItem.CartItemsCount);
            var mouse = new CartItem("Mouse", 70m, 2);
            Console.WriteLine(CartItem.CartItemsCount);
            
            // Console.WriteLine(keyboard.Quantity);
        }
    }
}

