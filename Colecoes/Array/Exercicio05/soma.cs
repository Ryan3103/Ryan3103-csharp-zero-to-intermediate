int[] numeros = new int[5];

int soma = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o {i + 1} número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 5; i++)
{
    soma += numeros[i];
}

Console.WriteLine($"A soma dos números inseridos é {soma}");