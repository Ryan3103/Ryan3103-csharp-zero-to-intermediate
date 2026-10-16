class Veiculo
{
    public string Modelo { get; protected set; }

    public Veiculo(string modelo)
    {
        Modelo = modelo;
    }

    public virtual double CalcularConsumo()
    {
        return 0;
    }
}