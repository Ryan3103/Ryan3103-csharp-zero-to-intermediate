class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; private set; }
    public int QuantidadeEstoque { get; private set; }

    public Produto(string nome, decimal preco, int quantidadeEstoque)
    {
        Nome = nome;
        if (preco > 0)
        {
            Preco = preco;
        }
        else
        {
            Console.WriteLine("Digite um preço maior que zero.");
        }
        if (quantidadeEstoque >= 0)
        {
            QuantidadeEstoque = quantidadeEstoque;
        }
        else
        {
            Console.WriteLine("Digite uma quantidade positiva");
        }
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            QuantidadeEstoque += quantidade;
        }
        else
        {
            Console.WriteLine("Quantidade tem que ser maior que zero");
        }
    }
    public void RemoverEstoque(int quantidade)
    {
        if (quantidade > 0 && QuantidadeEstoque >= quantidade)
        {
            QuantidadeEstoque -= quantidade;
        }
        else
        {
            Console.WriteLine("Estoque indisponivel");
        }
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preço: R$ {Preco:F2}");
        Console.WriteLine($"Quantidade: {QuantidadeEstoque}");
    }
}