class Tarefa
{
    private string titulo;
    private string descricao;
    private bool concluida;

    public Tarefa(string titulo, string descricao)
    {
        Titulo = titulo;
        Descricao = descricao;
        concluida = false;
    }

    public string Titulo
    {
        get
        {
            return titulo;
        }
        set
        {
            if (value.Length >= 3)
            {
                titulo = value;
            }
        }
    }
    public string Descricao
    {
        get
        {
            return descricao;
        }
        set
        {
            if (value.Length >= 5)
            {
                descricao = value;
            }
        }
    }

    public bool Concluida
    {
        get
        {
            return concluida;
        }
        private set
        {
            concluida = value;
        }
    }
    public void Concluir()
    {
        concluida = true;
    }

    public void Reabrir()
    {
        concluida = false;
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Titulo: {titulo}");
        Console.WriteLine($"Descrição: {descricao}");
        Console.WriteLine($"Status: {concluida}");
    }
}