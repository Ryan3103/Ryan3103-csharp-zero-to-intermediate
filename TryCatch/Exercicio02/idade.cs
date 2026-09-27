Console.WriteLine("Digite uma idade: ");

try
{
    int idade = int.Parse(Console.ReadLine());

    Console.WriteLine($"Sua idade é: {idade}");
}

catch (FormatException)
{
    Console.WriteLine("Idade inválida!");
}