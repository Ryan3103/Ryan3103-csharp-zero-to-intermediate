Console.WriteLine("1 - Criança");
Console.WriteLine("2 - Adolescente");
Console.WriteLine("3 - Adulto");
Console.WriteLine("4 - Idoso");
Console.WriteLine("Digite uma opção (1-4)");
int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
    Console.WriteLine("Criança");
    break;

     case 2:
    Console.WriteLine("Adolescente");
    break;

     case 3:
    Console.WriteLine("Adulto");
    break;

     case 4:
    Console.WriteLine("Idoso");
    break;
}