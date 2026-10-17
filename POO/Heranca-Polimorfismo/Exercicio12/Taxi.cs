class Taxi : Transporte
{
    public Taxi(double tarifabase) : base("Táxi", tarifabase)
    {
    }
    public override double CalcularTarifa()
    {
        return TarifaBase * 1.25;
    }
}