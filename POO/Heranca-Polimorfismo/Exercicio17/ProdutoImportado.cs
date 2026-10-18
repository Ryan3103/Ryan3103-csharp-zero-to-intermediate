class ProdutoImportado : Produto
{
    public ProdutoImportado(string nome, double preco) : base(nome, preco)
    {
    }

    public override double CalcularPrecoFinal()
    {
        return Preco * 1.15;
    }
}