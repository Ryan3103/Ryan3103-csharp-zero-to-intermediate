try
{
    Console.WriteLine("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());

    Console.WriteLine($"Número digitado: {numero}");
}
catch (FormatException)
{
    Console.WriteLine("Número inválido!");
}
finally
{
    Console.WriteLine("Programa finalizado!");
}