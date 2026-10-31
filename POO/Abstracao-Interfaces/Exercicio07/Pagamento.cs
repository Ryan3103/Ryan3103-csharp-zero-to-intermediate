abstract class Pagamento
{
    public decimal Valor{get; set;}

    public Pagamento(decimal valor)
    {
        Valor = valor;
    }

    public abstract decimal RealizarPagamento();
}