class Smartphone : Equipamento
{
    public int Armazenamento {get; set;}

    public Smartphone(string nome, decimal preco, int armazenamento) : base(nome, preco)
    {
        Armazenamento = armazenamento;
    }
    
    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Armazenamento: {Armazenamento}");
    }
}