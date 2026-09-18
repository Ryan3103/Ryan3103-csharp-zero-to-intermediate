try
{
    Console.WriteLine("Digite o 1º número: ");
    int numero1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o 2º número: ");
    int numero2 = int.Parse(Console.ReadLine());

    double divisao = (double)numero1 / numero2;

    Console.WriteLine($"Resultado: {divisao}");
}

catch (FormatException)
{
    Console.WriteLine("Número inválido!");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Não é possível dividir por zero!");
}
finally
{
    Console.WriteLine("Programa finalizado!");
}