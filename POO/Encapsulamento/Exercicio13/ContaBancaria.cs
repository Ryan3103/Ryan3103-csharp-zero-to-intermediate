class ContaBancaria
{
    private string titular;
    private double saldo;

    public string Titular
    {
        get
        {
            return titular;
        }
        set
        {
            if (value.Length >= 3)
            {
                titular = value;
            }
        }
    }

    public double Saldo
    {
        get
        {
            return saldo;
        }
        private set
        {
            saldo = value;
        }
    }

    public ContaBancaria(string titular, double saldoInicial)
    {
        Titular = titular;
        Saldo = 0;
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
        }
    }

    public void Sacar(double valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor;
        }
    }

    public void MostrarSaldo()
    {
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: {Saldo}");
        Console.WriteLine();
    }
}