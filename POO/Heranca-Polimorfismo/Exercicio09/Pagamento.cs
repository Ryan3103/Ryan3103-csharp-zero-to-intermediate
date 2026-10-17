class Pagamento
{
    public double Valor { get; protected set; }

    public Pagamento(double valor)
    {
        Valor = valor;
    }
    
    public virtual double CalcularValorFinal()
    {
        return Valor;
    }
}