namespace OPP.Payment.Implementation;

public class CreditCard : IPayment
{
    public void ProcessPayment(Cart cart)
    {
        Console.WriteLine("Generating credit card payment...");
        Console.WriteLine($"Credit card price: {cart.GetTotalPrice().ToString("C")}");
    }
}