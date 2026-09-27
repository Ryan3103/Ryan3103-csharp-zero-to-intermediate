System.Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

int multiplicador = 1;

while (multiplicador <= 10)
{
    System.Console.WriteLine($"A multiplicação de {numero} x {multiplicador} é: {numero * multiplicador}");
    multiplicador++;
}