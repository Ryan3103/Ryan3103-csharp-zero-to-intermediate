Console.WriteLine("1 - Comprar");
Console.WriteLine("2 - Consultar saldo");
Console.WriteLine("3 - Sair");
int opcao = int.Parse(Console.ReadLine());

double saldo = 100;


switch (opcao)
{
    case 1:
        Console.WriteLine("Digite o valor da compra: ");
        double compra = double.Parse(Console.ReadLine());

        if (saldo < compra)
        {
            Console.WriteLine("Pouco saldo!");
        }
        else
        {
            saldo = saldo - compra;
            Console.WriteLine($"Compra efetuada, valor restante do saldo: {saldo}");
        }
        break;

    case 2:

        Console.WriteLine($"Seu saldo é de: {saldo}");
        break;

    case 3:
        Console.WriteLine("Saindo do sistema...");
        break;
}