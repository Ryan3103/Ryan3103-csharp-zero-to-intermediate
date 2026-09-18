Console.WriteLine("Digite um número: ");

try
{
    int numero = int.Parse(Console.ReadLine());

    Console.WriteLine($"Você digitou {numero}");
}
catch
{
    Console.WriteLine("Digite apenas números");
}