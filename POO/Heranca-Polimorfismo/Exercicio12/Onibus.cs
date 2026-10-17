class Onibus : Transporte
{
    public Onibus(double tarifabase) : base("Ônibus", tarifabase)
    {
    }

    public override double CalcularTarifa()
    {
        return TarifaBase * 0.90;
    }
}