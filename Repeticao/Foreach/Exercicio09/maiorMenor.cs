int [] numeros = {15, 4, 27, 9, 31, 12, 6};

int maior = numeros[0];
int menor = numeros[0];

foreach (int numero in numeros)
{
    if (numero > maior)
    {
        maior = numero;
    }
    if (numero < menor)
    {
        menor = numero;
    }
}

Console.WriteLine($"O maior número é: {maior}");
Console.WriteLine($"O menor número é: {menor}");