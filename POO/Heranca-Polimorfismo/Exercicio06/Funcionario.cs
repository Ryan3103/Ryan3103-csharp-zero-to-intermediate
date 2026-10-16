class Funcionario
{
    public string Nome { get; protected set; }

    public Funcionario(string nome)
    {
        Nome = nome;
    }

    public virtual double CalcularPagamento()
    {
        return 0;
    }
}