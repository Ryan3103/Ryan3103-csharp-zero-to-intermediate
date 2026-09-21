int opcao  = 0;

string [] nomes = new string [10];
double [] valores = new double [10];

while (opcao != 6)
{
Console.WriteLine("===== CONTROLE DE GASTOS =====");
Console.WriteLine("1 - Adicionar gasto");
Console.WriteLine("2 - Listar gastos");
Console.WriteLine("3 - Ver total gasto");
Console.WriteLine("4 - Ver maior gasto");
Console.WriteLine("5 - Ver quantidade de gastos");
Console.WriteLine("6 - Sair");
Console.WriteLine("Escolha uma opção:");
opcao = int.Parse(Console.ReadLine());

switch (opcao) 
{
    case 1:

    Console.WriteLine("Digite o nome do gasto: ");
    string nomeDoGasto = Console.ReadLine();
    Console.WriteLine("Digite o valor: ");
    double valor = double.Parse(Console.ReadLine());
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