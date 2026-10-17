class PagamentoCartao : Pagamento
{
    public PagamentoCartao(double valor) : base(valor)
    {
    }

    public override double CalcularValorFinal()
    {
        return Valor * 1.10;
    }
}