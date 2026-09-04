int [] numeros = {12, 5, 28, 9, 34, 17 };

int maior = 1;

foreach (int numero in numeros)
{
    if (numero > maior)
    {
        maior = numero;
    }
}
Console.WriteLine($"O maior número é {maior}");