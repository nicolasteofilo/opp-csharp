using System.Globalization;

namespace OPP
{
    class Program
    {
        private static void Main()
        {
            var bankAccount = new BankAccount(0m, "John Doe");
            // bankAccount.Deposit(100);
            // Console.WriteLine(bankAccount.GetBalance());
            
            var keyboard = new CartItem("Logitech Keyboard", 100.30m);
            var mouse = new CartItem("Mouse", 70m, 4);
            
            var cart = new Cart();
            cart.AddItem(keyboard);
            cart.AddItem(mouse);
            
            cart.PrintItems();
        }
    }
}

