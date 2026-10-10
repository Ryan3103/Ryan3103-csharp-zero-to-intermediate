class ContaBancaria
{
    public string titulo;
    private double saldo;

    public ContaBancaria(string titulo, double saldo)
    {
        this.titulo = titulo;
        this.saldo = saldo;
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
        }
    }

    public void Sacar(double valor)
    {
        if (valor > 0 && saldo >= valor)
        {
            saldo -= valor;
        }
    }

    public void Apresentar()
    {
        Console.WriteLine($"Saldo atual: {saldo}");
    }
}