class Gerente : Funcionario
{
    public Gerente(string nome, double salariobase) : base(nome, salariobase)
    {
    }

    public override double CalcularSalario()
    {
        return SalarioBase * 1.20;
    }
}