Console.WriteLine("===== CONTROLE DE GASTOS =====");
Console.WriteLine("1 - Adicionar gasto");
Console.WriteLine("2 - Listar gastos");
Console.WriteLine("3 - Ver total gasto");
Console.WriteLine("4 - Ver maior gasto");
Console.WriteLine("5 - Ver quantidade de gastos");
Console.WriteLine("6 - Sair");
Console.WriteLine("Escolha uma opção:");
int opcao = int.Parse(Console.ReadLine());


while (opcao != 6)
{
switch (opcao) 
{
    case 1:

    Console.WriteLine("Digite o nome do gasto: ");
    string nomeDoGasto = Console.ReadLine();
    Console.WriteLine("Digite o valor: ");
    int valor = int.Parse(Console.ReadLine());
    break;

    case 2:
    Console.WriteLine("===== GASTOS =====");
    Console.WriteLine($"1 - Alimentação: ");
    Console.WriteLine("2 - Transporte: ");
    Console.WriteLine("3 - Jogo: ");
    break;

    case 3:
    Console.WriteLine("Total gasto: ");
    break;
}
}