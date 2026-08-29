Console.WriteLine("1 - Cadastrar");
Console.WriteLine("2 - Consultar");
Console.WriteLine("3 - Editar");
Console.WriteLine("4 - Sair");
int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
    Console.WriteLine("Cadastrar");
    break;
    case 2:
    Console.WriteLine("Consultar");
    break;
    case 3:
    Console.WriteLine("Editar");
    break;
    case 4:
    Console.WriteLine("Sair");
    break;
    default:
    Console.WriteLine("Opção invalida!");
    break;
}