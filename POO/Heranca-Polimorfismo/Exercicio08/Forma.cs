class Forma
{
    public string Nome { get; protected set; }

    public Forma(string nome)
    {
        Nome = nome;
    }

    public virtual double CalcularArea()
    {
        return 0;
    }
}