namespace OPP.Freight;

public class FreightOption
{
    public string Name { get; private set; }
    public decimal Value { get; private set; }
    public int DeadlineInDays { get; private set; }

    public FreightOption(string name, decimal value, int deadlineInDays)
    {
        Name = name;
        Value = value;
        DeadlineInDays = deadlineInDays;
    }
}
