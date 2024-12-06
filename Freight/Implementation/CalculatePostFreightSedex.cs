namespace OPP.Freight.Implementation;

public class CalculatePostFreightSedex : PostFreight
{
    protected override string Name() => "Sedex";

    protected override decimal Value() => 30M;

    protected override int DeadlineInDays() => 3;
}
