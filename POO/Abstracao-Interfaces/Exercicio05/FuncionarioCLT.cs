class FuncionarioCLT : Funcionario, IRelatorio
{
    public FuncionarioCLT(string nome, decimal salario) : base(nome, salario)
    {
    }

    public override decimal CalcularBonus()
    {
        return Salario * 0.10m;
    }

    public void GerarRelatorio()
    {
        Console.WriteLine($"Relatório CLT: {Nome}");
    }
}