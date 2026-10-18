class Produto
{
    public string Nome {get; protected set;}
    public double Preco {get; protected set;}

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public virtual double CalcularPrecoFinal()
    {
        return Preco;
    }
}