class Pix : Pagamento
{
    public Pix(decimal valor) : base(valor)
    {
    }

    public override decimal CalcularTaxa()
    {
        return Valor * 0.01m;
    }

    public override void Processar()
    {
        Console.WriteLine("Processando pagamento por pix.");
    }
}