class Funcionario
{
    public string Nome { get; private set; }
    public string Cargo { get; private set; }
    public double Salario { get; private set; }

    public Funcionario(string nome, string cargo, double salario)
    {
        Nome = nome;
        Cargo = cargo;
        Salario = salario;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Cargo: {Cargo}");
        Console.WriteLine($"Salário: R$ {Salario:F2}");
    }
}