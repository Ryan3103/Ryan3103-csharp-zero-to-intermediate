class Funcionario
{
    public string Nome { get; protected set; }
    public double SalarioBase { get; protected set; }

    public Funcionario(string nome, double salariobase)
    {
        Nome = nome;
        SalarioBase = salariobase;
    }

    public virtual double CalcularSalario()
    {
        return SalarioBase;
    }
}