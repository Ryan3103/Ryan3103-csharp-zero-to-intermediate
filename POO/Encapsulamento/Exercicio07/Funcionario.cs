class Funcionario
{
    public string nome;
    private double salario;
    internal string departamento;
    protected double bonus;

    public Funcionario(string nome, double salario, string departamento)
    {
        this.nome = nome;
        this.salario = salario;
        this.departamento = departamento;
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Nome: {nome}, Salario: {salario}, Departamento: {departamento}");
    }
}