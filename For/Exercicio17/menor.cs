Console.WriteLine("Digite o 1* número: ");
int menor = int.Parse(Console.ReadLine());

for (int i = 2; i <= 5; i++)
{
    Console.WriteLine($"Digite o {i}* número: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero < menor)
    {
        menor = numero;
    }
}

Console.WriteLine($"Menor número: {menor}");