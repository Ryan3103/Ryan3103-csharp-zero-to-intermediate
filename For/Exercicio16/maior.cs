int maior = 0;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Digite o {i}* número: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero > maior)
    {
        maior = numero;
    }
}

Console.WriteLine($"Maior número: {maior}");