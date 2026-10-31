class DescontoVIP : Desconto
{
    public override double Calcular(double valor)
    {
        return valor * 0.80;
    }
}