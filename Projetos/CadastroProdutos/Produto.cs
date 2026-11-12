class Produto
{
    public string Nome { get; private set; }
    public double Preco { get; private set; }
    public int Estoque { get; private set; }

    public Produto(string nome, double preco, int estoque)
    {
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preço: R$ {Preco:F2}");
        Console.WriteLine($"Estoque: {Estoque}");
    }
}