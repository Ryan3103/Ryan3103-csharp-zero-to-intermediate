try
{
    Console.WriteLine("Digite sua idade: ");

    int idade = int.Parse(Console.ReadLine());

    if (idade < 0)
    {
        throw new Exception("A idade não pode ser negativa!");
    }

    Console.WriteLine($"Sua idade é: {idade}");
}
catch (FormatException)
{
    Console.WriteLine("Digite uma idade válida!");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Programa finalizado!");
}