Console.WriteLine("1 - Hambúrguer - R$ 20");
Console.WriteLine("2 - Pizza - R$ 35");
Console.WriteLine("3 - X-Bacon - R$ 25");
Console.WriteLine("4 - Refrigerante - R$ 7");
Console.WriteLine("Digite a opção (1-4)");
int opc = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade: ");
int quant = int.Parse(Console.ReadLine());

switch (opc)
{
    case 1:
    int hamburger = quant * 20;
    Console.WriteLine($"Total: R${hamburger}");
    break;

    case 2:
    int pizza = quant * 35;
    Console.WriteLine($"Total: R${pizza}");
    break;

    case 3:
    int x = quant * 25;
    Console.WriteLine($"Total: R${x}");
    break;

    case 4:
    int refri = quant * 7;
    Console.WriteLine($"Total: R${refri}");
    break;

    default:
    Console.WriteLine("Opção invalida!");
    break;
}