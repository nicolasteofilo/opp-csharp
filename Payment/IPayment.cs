namespace OPP.Payment;

public interface IPayment
{
    void ProcessPayment(Cart cart);
}