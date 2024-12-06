namespace OPP.Freight.Implementation;

public abstract class PostFreight : ICalculateFreight
{
    protected abstract string Name();
    protected abstract decimal Value();
    protected abstract int DeadlineInDays();

    public FreightOption Calculate(Cart cart)
    {
        string serviceName = Name();
        if (string.IsNullOrWhiteSpace(serviceName))
        {
            throw new ArgumentException("Service name is empty");
        }

        return new FreightOption(Name(), Value(), DeadlineInDays());
    }
}
