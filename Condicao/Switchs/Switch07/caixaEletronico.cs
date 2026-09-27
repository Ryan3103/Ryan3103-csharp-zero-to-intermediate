Console.WriteLine("1 - Consultar saldo");
Console.WriteLine("2 - Sacar");
Console.WriteLine("3 - Depositar");
Console.WriteLine("4 - Sair");
int opcao = int.Parse(Console.ReadLine());

double saldo = 1000;

switch (opcao)
{
    case 1:
    Console.WriteLine($"Seu saldo disponivel é de: {saldo}");
    break;

    case 2:
    Console.WriteLine("Digite o valor do saque: ");
    double saque = double.Parse(Console.ReadLine());

    if (saldo >= saque)
        {
            double resto = saldo - saque;

            Console.WriteLine("Saque realizado com sucesso!");
            Console.WriteLine($"Valor restante no saldo: {resto}");
        }
    else 
     Console.WriteLine($"Valor indisponivel!");
     
     break;

     case 3:
     Console.WriteLine("Digite o valor do deposito: ");
     double deposito = double.Parse(Console.ReadLine());

     double novoValor = deposito + saldo; 

    Console.WriteLine($"O valor depositado é {deposito}");
    Console.WriteLine($"O novo saldo da sua conta é: {novoValor}");
    break;

    case 4:
    Console.WriteLine("Saindo do sistema...");
    break;

    default:
    Console.WriteLine("Opção invalida!");
    break;
}