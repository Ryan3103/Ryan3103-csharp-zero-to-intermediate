class Desenvolvedor : Funcionario
{
    public Desenvolvedor(string nome, double salariobase) : base (nome, salariobase)
    {
    }

    public override double CalcularSalario()
    {
        return SalarioBase * 1.10;
    }
}