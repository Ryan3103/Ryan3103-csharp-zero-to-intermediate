class ContaBancaria
{
    public string titular;
    private double saldo;

    public ContaBancaria (string titular, double saldo)
    {
        this.titular = titular;
        this.saldo = saldo;
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
        }
    }

    public void ConsultarSaldo()
    {
        Console.WriteLine($"Saldo atual: {saldo}");
    }
}