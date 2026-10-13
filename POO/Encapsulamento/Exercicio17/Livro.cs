class Livro
{
    private string titulo;
    private string autor;
    private bool emprestado;

    public Livro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
        Emprestado = false;
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

    public string Autor
    {
        get
        {
            return autor;
        }
        set
        {
            if (value.Length >= 3)
            {
                autor = value;
            }
        }
    }

    public bool Emprestado
    {
        get
        {
            return emprestado;
        }
        private set
        {
            emprestado = value;
        }
    }

    public void Emprestar()
    {
        if (emprestado == false)
        {
            emprestado = true;
        }
    }

    public void Devolver()
    {
        if (emprestado == true)
        {
            emprestado = false;
        }
    }
    public void MostrarDados()
    {
        Console.WriteLine($"Titulo: {titulo}");
        Console.WriteLine($"Autor: {autor}");
        Console.WriteLine($"Status: {(emprestado ? "Emprestado" : "Disponivel")}");
    }
}