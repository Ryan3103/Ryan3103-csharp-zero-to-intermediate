class Usuario
{
    private string nome;
    private int idade;
    private string email;

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

    public int Idade
    {
        get
        {
            return idade;
        }
        set
        {
            if (value >= 18 && value <= 100)
            {
                idade = value;
            }
        }
    }

    public string Email
    {
        get
        {
            return email;
        }
        set
        {
            if (value.Contains("@"))
            {
                email = value;
            }
        }
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Email: {email}");
    }
}