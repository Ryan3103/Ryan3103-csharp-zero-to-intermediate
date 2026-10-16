class FuncionarioFreelancer : Funcionario
{
    public double ValorPorProjeto { get; private set; }
    public int QuantidadeProjetos { get; private set; }
    public FuncionarioFreelancer(string nome, double valorPorProjeto, int quantidadeProjetos) : base(nome)
    {
        ValorPorProjeto = valorPorProjeto;
        QuantidadeProjetos = quantidadeProjetos;
    }

    public override double CalcularPagamento()
    {
        return ValorPorProjeto * QuantidadeProjetos;
    }
}