class Aluno
{
    private double nota;
    public double Nota
    {
        get
        {
            return nota;
        }
        set
        {
            if (value >= 0 && value <= 10)
            {
                nota = value;
            }
        }
    }

    public string Nome {get; set;}
    
    public void MostrarNota()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Nota atual: {Nota}");
    }
}