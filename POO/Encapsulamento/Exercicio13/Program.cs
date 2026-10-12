ContaBancaria conta = new ContaBancaria("Ryan", 0);

conta.MostrarSaldo();

conta.Depositar(500);
conta.MostrarSaldo();

conta.Sacar(150);
conta.MostrarSaldo();

conta.Sacar(1000);
conta.Depositar(-50);
conta.MostrarSaldo();
