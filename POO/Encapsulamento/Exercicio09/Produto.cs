class Produto
{
    public string Nome;
    private double preco;
    private int estoque;

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
        set
        {
            if (value >= 0)
            {
                estoque = value;
            }
        }
    }

    public void MostrarDados()
    {
        Console.WriteLine(Nome);
        Console.WriteLine(Preco);
        Console.WriteLine(Estoque);
    }

}