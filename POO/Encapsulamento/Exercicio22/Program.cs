ContaBancaria conta1 = new ContaBancaria("Ryan", 100);

Console.WriteLine(conta1.Saldo);
conta1.Depositar(50);
Console.WriteLine(conta1.Saldo);
conta1.Sacar(30);
Console.WriteLine(conta1.Saldo);
conta1.Sacar(200);
Console.WriteLine(conta1.Saldo);