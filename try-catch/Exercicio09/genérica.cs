try
{
    Console.WriteLine("Digite o 1º número: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o 2º número: ");
    int n2 = int.Parse(Console.ReadLine());

    double divisao = (double)n1 / n2;

    Console.WriteLine($"Resultado: {divisao}");
}
catch (FormatException)
{
    Console.WriteLine("Entrada inválida!");
}
catch (Exception)
{
    Console.WriteLine("Outra exceção");
}

finally
{
    Console.WriteLine("Programa finalizado!");
}