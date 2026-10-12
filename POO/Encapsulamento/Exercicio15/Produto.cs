class Produto
{
    private string nome;
    private double preco;
    private int estoque;

    public Produto(string nome, double preco, int estoque)
    {
        Nome = nome;
        Preco = preco;
        Estoque = 0;
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

    public double Preco
    {
        get
        {
            return preco;
        }
        set
        {
            if (value > 0)
            {
                preco = value;
            }
        }
    }

    public int Estoque
    {
        get
        {
            return estoque;
        }
        private set
        {
            estoque = value;
        }
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            Estoque += quantidade;
        }
    }
    public void RetirarEstoque(int quantidade)
    {
        if (quantidade > 0 && quantidade <= estoque)
        {
            Estoque -= quantidade;
        }
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Preço: {preco}");
        Console.WriteLine($"Quantidade: {estoque}");
    }
}