Console.WriteLine("1 - Consultar saldo");
Console.WriteLine("2 - Depositar");
Console.WriteLine("3 - Sacar");
Console.WriteLine("4 - Verificar situação da conta");
int opcao = int.Parse(Console.ReadLine());

double saldo = 1000;



    switch (opcao)
{
    case 1:
    Console.WriteLine($"Seu saldo: {saldo}");
    break;

    case 2:
    
    Console.WriteLine("Qual o valor do deposito? ");
    
    int deposito = int.Parse(Console.ReadLine());
    
    Console.WriteLine($"Seu novo saldo é: {saldo += deposito}");
    break;
}

if (saldo > 1000)
    Console.WriteLine("Cliente Premium");
else if (saldo >= 500)
    Console.WriteLine("Cliente comum");
else
    Console.WriteLine("Cliente básico");
