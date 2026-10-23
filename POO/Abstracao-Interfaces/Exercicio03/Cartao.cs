class Cartao : Pagamento
{
    public Cartao(decimal valor) : base(valor)
    {
    }

    public override decimal CalcularTaxa()
    {
        return Valor * 0.03m;
    }

    public override void Processar()
    {
        Console.WriteLine("Processando pagamento por cartão");
    }
}