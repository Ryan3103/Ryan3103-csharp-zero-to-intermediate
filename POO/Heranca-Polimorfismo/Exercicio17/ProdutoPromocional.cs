class ProdutoPromocional : Produto
{
    public ProdutoPromocional(string nome, double preco) : base(nome, preco)
    {
    }

    public override double CalcularPrecoFinal()
    {
        if (Preco >= 100)
        {
            return Preco * 0.80;
        }
        else
        {
            return Preco * 0.90;
        }
    }
}