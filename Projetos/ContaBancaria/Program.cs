ContaBancaria conta = new ContaBancaria("Ryan", 12345);

Console.WriteLine($"Saldo inicial: R$ {conta.ConsultarSaldo():F2}");
conta.Depositar(500);
Console.WriteLine($"Após depósito: R$ {conta.ConsultarSaldo():F2}");
conta.Sacar(150);
Console.WriteLine($"Após saque: R$ {conta.ConsultarSaldo():F2}");
Console.WriteLine($"Saldo final: R$ {conta.ConsultarSaldo():F2}");