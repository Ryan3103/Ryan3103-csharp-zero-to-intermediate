class PagamentoCartao  : Pagamento
{
    public PagamentoCartao(decimal preco) : base(preco)
    {
    }
    public override decimal RealizarPagamento()
    {
        return Valor;
    }
}