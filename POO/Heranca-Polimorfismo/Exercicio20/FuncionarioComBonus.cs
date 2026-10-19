class FuncionarioComBonus : Funcionario
{
    public double Bonus;

    public FuncionarioComBonus(string nome, double salariobase, double bonus) : base(nome, salariobase)
    {
        Bonus = bonus;
    }

    public override double CalcularSalario()
    {
        return SalarioBase + Bonus;
    }
}