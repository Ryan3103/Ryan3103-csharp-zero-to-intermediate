class Funcionario
{
    private string nome;
    private double salario;


    public Funcionario(string nome, double salarioInicial)
    {
        Nome = nome;

        if (salarioInicial > 0)
        {
            salario = salarioInicial;
        }
        else
        {
            salario = 0;
        }
    }
    public string Nome
    {
        get
        {
            return nome;
        }
        set
        {
            if (value.Length >= 3)
            {
                nome = value;
            }
        }
    }

    public double Salario
    {
        get
        {
            return salario;
        }
        private set
        {
            salario = value;
        }
    }

    public void AumentarSalario(double percentual)
    {
        if (percentual > 0)
        {
            Salario = Salario * (1 + percentual / 100);
        }
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Salário: R$ {Salario:F2}");
    }

}