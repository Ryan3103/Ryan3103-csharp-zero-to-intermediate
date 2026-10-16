class Moto : Veiculo
{
    public Moto(string Modelo) : base(Modelo)
    {
    }

    public override double CalcularConsumo()
    {
        return 30;
    }
}