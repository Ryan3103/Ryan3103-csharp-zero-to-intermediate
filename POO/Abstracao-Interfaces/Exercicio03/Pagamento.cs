abstract class Pagamento : IProcessavel
{
    public decimal Valor {get; set;}

    public Pagamento(decimal valor)
    {
        Valor = valor;
    }

    public abstract decimal CalcularTaxa();

    public abstract void Processar();
}