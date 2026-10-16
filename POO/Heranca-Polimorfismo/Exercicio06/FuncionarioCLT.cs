class FuncionarioCLT : Funcionario
{
    public double SalarioMensal { get; private set; }
    public FuncionarioCLT(string nome, double salarioMensal) : base(nome)
    {
        SalarioMensal = salarioMensal;
    }

    public override double CalcularPagamento()
    {
        return SalarioMensal;
    }
}