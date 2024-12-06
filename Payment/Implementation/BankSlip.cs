namespace OPP.Payment.Implementation;

public class BankSlip : IPayment
{
    public void ProcessPayment(Cart cart)
    {
        Console.WriteLine("Generating bank slip...");
        Console.WriteLine($"Bank slip price: {cart.GetTotalPrice().ToString("C")}");
    }
}