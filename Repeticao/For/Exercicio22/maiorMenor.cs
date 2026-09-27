Console.WriteLine("Digite o 1* número: ");
int menor = int.Parse(Console.ReadLine());

int maior = 1;

for (int i = 2; i <= 10; i++)
{
    Console.WriteLine($"Digite o {i}* número: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero > maior)
    {
        maior = numero;
    }
    else if (numero < menor)
    {
        menor = numero;
    }
}

Console.WriteLine($"Maior número: {maior}");
Console.WriteLine($"Menor número: {menor}");