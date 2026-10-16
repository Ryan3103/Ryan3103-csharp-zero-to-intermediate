class Carro : Veiculo
{
    public Carro(string Modelo) : base(Modelo)
    {
    }
    public override double CalcularConsumo()
    {
        return 12;
    }
}