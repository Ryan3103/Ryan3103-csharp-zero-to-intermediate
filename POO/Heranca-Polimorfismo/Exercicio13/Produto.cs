class Produto
{
    public string Nome {get; protected set;}
    public double PrecoBase {get; protected set;}

    public Produto(string nome, double precobase)
    {
        Nome = nome;
        PrecoBase = precobase;
    }

    public virtual double CalcularPrecoFinal()
    {
        return PrecoBase;
    }
}