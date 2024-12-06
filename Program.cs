using OPP;
using OPP.Freight;
using OPP.Freight.Implementation;
using OPP.Payment.Implementation;

var bankAccount = new BankAccount(0m, "John Doe");
// bankAccount.Deposit(100);
// Console.WriteLine(bankAccount.GetBalance());

var keyboard = new CartItem("Logitech Keyboard", 100.30m);
var mouse = new CartItem("Mouse", 70m, 4);

var cart = new Cart();
cart.AddItem(keyboard);
cart.AddItem(mouse);
cart.Pay(new BankSlip());

FreightOption calculateFreight = new CalculatePostFreightPac().Calculate(cart);
Console.WriteLine($"{calculateFreight.Name}");
