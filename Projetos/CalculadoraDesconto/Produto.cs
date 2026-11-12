class Produto
{
    public string Nome {get; private set;}
    public double Preco {get; private set;}

    public Produto (string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public double CalcularDesconto(double percentual)
    {
        return Preco * (percentual / 100);
    }
    public double CalcularPrecoFinal(double percentual)
    {
        return Preco - CalcularDesconto(percentual);
    }
}