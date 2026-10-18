class Gerente : Funcionario
{
    public Gerente(string nome, double salariobase) : base(nome, salariobase)
    {
    }

    public override double NovoValor()
    {
        return SalarioBase * 1.20;
    }
}