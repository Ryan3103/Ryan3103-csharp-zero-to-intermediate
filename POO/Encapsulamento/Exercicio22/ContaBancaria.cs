class ContaBancaria
{
    public string Titular { get; set; }
    public decimal Saldo { get; private set; }

    public ContaBancaria(string titular, decimal saldo)
    {
        Titular = titular;

        if (saldo >= 0)
        {
            Saldo = saldo;
        }
        else
        {
            Console.WriteLine("Saldo inicial inválido.");
        }
    }

    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
        }
        else
        {
            Console.WriteLine("Valor inválido");
        }
    }
    public void Sacar(decimal valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saque indisponivel");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Nome: {Titular}");
        Console.WriteLine($"Saldo atual: {Saldo:F2}");
    }
}