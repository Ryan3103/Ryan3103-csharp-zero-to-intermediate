class Freelancer : Funcionario
{
    public  int Quantidade {get; protected set;}
    public double ValorPorProjeto { get; protected set; }

    public Freelancer(string nome, double valorPorProjeto, int quantidade) : base(nome, 0)
    {
        Quantidade = quantidade;
        ValorPorProjeto = valorPorProjeto;
    }

    public override double NovoValor()
    {
        return ValorPorProjeto * Quantidade;
    }
}