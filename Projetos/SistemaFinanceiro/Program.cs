Conta conta = new Conta("Ryan", 1000m);

Console.WriteLine(conta.NomeTitular);
Console.WriteLine(conta.Saldo);

Movimentacao salario = new Movimentacao("Sálario", 500m, true);
conta.RegistrarMovimentacao(salario);

Console.WriteLine(conta.Saldo);

Movimentacao almoco = new Movimentacao("Almoço", 200m, false);
conta.RegistrarMovimentacao(almoco);

Console.WriteLine(conta.Saldo);

foreach(Movimentacao item in conta.Movimentacoes)
{
    Console.WriteLine(item.Descricao);
}