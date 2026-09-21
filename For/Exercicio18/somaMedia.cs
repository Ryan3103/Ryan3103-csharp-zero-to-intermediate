int soma = 0;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Digite o {i}* número: ");
    int numero = int.Parse(Console.ReadLine());

    soma += numero;
}

double media = soma / 5;

Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Média: {media}");