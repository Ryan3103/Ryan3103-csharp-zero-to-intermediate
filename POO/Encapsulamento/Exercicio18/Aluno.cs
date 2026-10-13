class Aluno
{
    private string nome;
    private double nota;

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

    public double Nota
    {
        get
        {
            return nota;
        }
        private set
        {
            nota = value;
        }
    }

    public Aluno(string nome, double notaInicial)
    {
        Nome = nome;
        if (notaInicial >= 0 && notaInicial <= 10)
        {
            nota = notaInicial;
        }
        else
        {
            nota = 0;
        }
    }

    public void AlterarNota(double novaNota)
    {
        if (novaNota >= 0 && novaNota <= 10)
        {
            nota = novaNota;
        }
    }
    public bool VerificarAprovacao()
    {
        return nota >= 6;
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Nota: {nota}");
        Console.WriteLine($"Situação: {(VerificarAprovacao() ? "Aprovado" : "Reprovado")}");
    }
}