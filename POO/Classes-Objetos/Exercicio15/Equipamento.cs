class Equipamento
{
    public string Nome { get; set; }
    public decimal Preco { get; protected set; }

    public Equipamento(string nome, decimal preco)
    {
        Nome = nome;
        if (preco > 0)
        {
            Preco = preco;
        }
        else
        {
            Console.WriteLine("Preço inválido.");
        }
    }

    public void AlterarPreco(decimal novoPreco)
    {
        if (novoPreco > 0)
        {
            Preco = novoPreco;
        }
        else
        {
            Console.WriteLine("Preço inválido.");
        }
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preço: R$ {Preco:F2}");
        Console.WriteLine();
    }
}