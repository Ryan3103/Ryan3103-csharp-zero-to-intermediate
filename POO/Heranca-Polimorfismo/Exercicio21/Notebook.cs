class Notebook : Equipamento
{
    public int MemoriaRAM { get; set; }

    public Notebook(string nome, decimal preco, int memoriaRAM) : base(nome, preco)
    {
        MemoriaRAM = memoriaRAM;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Memória RAM: {MemoriaRAM}");
    }
}