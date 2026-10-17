class ProdutoDigital : Produto
{
    public ProdutoDigital(string nome, double precobase) : base(nome, precobase)
    {
    }

    public override double CalcularPrecoFinal()
    {
        return PrecoBase * 0.90;
    }
}