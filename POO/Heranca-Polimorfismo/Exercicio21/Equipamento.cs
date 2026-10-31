class Equipamento
{
    public string Nome { get; set; }
    public decimal Preco {get; set;}

    public Equipamento(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preço: {Preco:F2}");
    }
}