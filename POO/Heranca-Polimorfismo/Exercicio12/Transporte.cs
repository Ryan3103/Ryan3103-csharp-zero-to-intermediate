class Transporte
{
    public string Nome {get; protected set;}
    public double TarifaBase {get; protected set;}

    public Transporte(string nome, double tarifabase)
    {
        Nome = nome;
        TarifaBase = tarifabase;
    }

    public virtual double CalcularTarifa()
    {
        return TarifaBase;
    }
}