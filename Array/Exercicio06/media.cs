int [] numeros = new int [5];

int soma = 0;
double media = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o {i + 1} número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 5; i++)
{
    soma += numeros[i];
}

media = soma / 5;

Console.WriteLine($"Média: {media}");