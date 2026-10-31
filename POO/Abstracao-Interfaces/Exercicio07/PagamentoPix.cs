class PagamentoPix : Pagamento
{
    public PagamentoPix(decimal valor) : base(valor)
    {
    }
    public override decimal RealizarPagamento()
    {
        return Valor;
    }
}