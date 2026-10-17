class ProdutoFisico : Produto
{
    public ProdutoFisico(string nome, double precobase) : base(nome, precobase)
    {
    }

    public override double CalcularPrecoFinal()
    {
        return PrecoBase + 15.00;
    }
}