namespace OPP.Freight;

public interface ICalculateFreight
{
    FreightOption Calculate(Cart cart);
}
