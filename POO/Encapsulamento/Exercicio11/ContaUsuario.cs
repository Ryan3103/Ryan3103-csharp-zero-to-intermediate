class ContaUsuario
{
    private string usuario;
    private string senha;
    private int tentativas;

    public string Usuario
    {
        get
        {
            return usuario;
        }

        set
        {
            if (value.Length >= 3)
            {
                usuario = value;
            }
        }
    }

    public string Senha
    {
        get
        {
            return senha;
        }
        set
        {
            if (value.Length >= 6)
            {
                senha = value;
            }
        }
    }

    public int Tentativas
    {
        get
        {
            return tentativas;
        }
        set
        {
            if (value >= 0 && value <= 5)
            {
                tentativas = value;
            }
        }
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Usuario: {Usuario}");
        Console.WriteLine($"Tentativas: {Tentativas}");
    }
}