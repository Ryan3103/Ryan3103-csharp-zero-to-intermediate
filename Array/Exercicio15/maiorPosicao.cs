int[] numeros = new int[5];

int maior = numeros[0];
int posicao = -1;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o {i + 1} número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 5; i++)
{
    if (numeros[i] > maior)
    {
        maior = numeros[i];
        posicao = i;
    }
}

Console.WriteLine($"Maior: {maior}");
Console.WriteLine($"Posição: {posicao}");