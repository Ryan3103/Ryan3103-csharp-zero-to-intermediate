class FuncionarioPJ : Funcionario, IRelatorio
{
    public FuncionarioPJ(string nome, decimal salario) : base(nome, salario)
    {
    }

    public override decimal CalcularBonus()
    {
        return Salario * 0.05m;
    }

    public void GerarRelatorio()
    {
        Console.WriteLine($"Relatório PJ: {Nome}");
    }
}