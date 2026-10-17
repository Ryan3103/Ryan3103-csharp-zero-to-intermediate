class PagamentoPix : Pagamento
{
    public PagamentoPix(double valor) : base(valor)
    {
    }

    public override double CalcularValorFinal()
    {   
        return Valor * 0.95;
    }
}