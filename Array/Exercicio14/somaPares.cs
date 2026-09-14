int [] numeros = new int [10];

int soma = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i + 1} número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{
    if (numeros[i] % 2 == 0)
    {
        soma += numeros[i];
    }
}

Console.WriteLine($"Soma dos pares: {soma}");