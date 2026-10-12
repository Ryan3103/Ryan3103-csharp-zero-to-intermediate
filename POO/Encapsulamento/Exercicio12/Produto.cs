class Produto
{
    private string Nome;
    private double Preco;
    private int Quantidade;

    public string nome
    {
        get
        {
            return Nome;
        }
        set
        {
            if (value.Length >= 3)
            {
                Nome = value;
            }
        }
    }

    public double preco
    {
        get
        {
            return Preco;
        }
        set
        {
            if (value > 0)
            {
                Preco = value;
            }
        }
    }

    public int quantidade
    {
        get
        {
            return Quantidade;
        }
        set
        {
            if (value >= 0)
            {
                Quantidade = value;
            }
        }
    }

    public double CalcularValorTotal()
    {
        return preco * quantidade;
    }

    public void MostrarDados()
    {
        Console.WriteLine($"{nome}, {preco}, {quantidade}, {CalcularValorTotal()}");
    }
}