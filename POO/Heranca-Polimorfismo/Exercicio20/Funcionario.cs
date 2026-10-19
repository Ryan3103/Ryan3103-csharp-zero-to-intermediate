class Funcionario
{
    public string Nome;
    public double SalarioBase;

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