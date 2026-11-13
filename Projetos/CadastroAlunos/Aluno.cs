class Aluno
{
    public string Nome {get; private set;}
    public double Nota {get; private set;}

    public Aluno (string nome, double nota)
    {
        if (nota < 0 || nota > 10)
    {
        throw new ArgumentException("Nota inválida.");
    }
    
        Nome = nome;
        Nota = nota;
    }

    public void AlterarNota(double novaNota)
    {
        if (novaNota < 0 || novaNota > 10)
        {
            throw new ArgumentException("Nota inválida.");
        }

        Nota = novaNota;
    }

    public bool VerificarAprovacao()
    {
        return Nota >= 6;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Nota: {Nota}");
    }
}