class ContaBancaria
{
    public string Titular { get; private set; }
    public int NumeroConta { get; private set; }
    public double Saldo { get; private set; }

    public ContaBancaria(string titular, int numeroConta)
    {
        if (titular == "")
        {
            throw new ArgumentException("Titular inválido.");
        }
        Titular = titular;

        if (numeroConta <= 0)
        {
            throw new ArgumentException("Número da conta inválido.");
        }
        NumeroConta = numeroConta;
    }

    public double Depositar(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("Valor inválido.");
        }

        Saldo += valor;
        return Saldo;
    }

    public double Sacar(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("Valor de saque inválido.");
        }
        if (valor > Saldo)
        {
            throw new ArgumentException("Saldo insuficiente.");
        }

        Saldo -= valor;
        return Saldo;
    }

    public double ConsultarSaldo()
    {
        return Saldo;
    }
}