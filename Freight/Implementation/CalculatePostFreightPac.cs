namespace OPP.Freight.Implementation;

public class CalculatePostFreightPac : PostFreight
{
    protected override string Name() => "PAC";

    protected override decimal Value() => 15M;

    protected override int DeadlineInDays() => 10;
}
