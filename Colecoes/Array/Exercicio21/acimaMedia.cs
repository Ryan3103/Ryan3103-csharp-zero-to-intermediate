int[] numeros = new int[5];

int soma = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número: ");
    numeros[i] = int.Parse(Console.ReadLine());

    soma += numeros[i];
}

double media = (double)soma / 5;

Console.WriteLine($"Média: {media}");

Console.WriteLine("Acima da média: ");
for (int i = 0; i < 5; i++)
{
    if (numeros[i] > media)
    {
        Console.WriteLine(numeros[i]);
    }
}