Console.WriteLine("Digite um número: ");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número: ");
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a operação: ");
string operacao = (Console.ReadLine());


switch (operacao)
{
    case "+":
    Console.WriteLine($"A soma é: {n1 + n2}");
    break;

     case "-":
    Console.WriteLine($"A subtração é: {n1 - n2}");
    break;

     case "*":
    Console.WriteLine($"A multiplicação é: {n1 * n2}");
    break;

     case "/":
    Console.WriteLine($"A dvisão é: {n1 / n2}");
    break;

    default:
    Console.WriteLine("Operação invalida!");
    break;
}