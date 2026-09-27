Console.WriteLine("Digite uma nota: (0-5)");
int nota = int.Parse(Console.ReadLine());

switch (nota)
{
    case 1:
    Console.WriteLine("Péssimo");
    break;

    case 2:
    Console.WriteLine("Ruim");
    break;

    case 3:
    Console.WriteLine("Regular");
    break;

    case 4:
    Console.WriteLine("Bom");
    break;

    case 5:
    Console.WriteLine("Excelente");
    break;

    default:
    Console.WriteLine("Opção invalída!");
    break;
}