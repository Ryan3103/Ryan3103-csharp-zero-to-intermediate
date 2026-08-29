Console.WriteLine("Digite 1, 2 ou 3!");
int numero = int.Parse(Console.ReadLine());

switch (numero)
{
    case 1:
    Console.WriteLine("Digitou 1!");
    break;

    case 2: 
    Console.WriteLine("Digitou 2!");
    break;

    case 3:
    Console.WriteLine("Digitou 3!");
    break;

    default:
    Console.WriteLine("Opção invalida!");
    break;
    }