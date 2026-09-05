int[] numeros = { 5, 12, 18, 3, 27, 8, 21, 30 };

int contador = 0;

foreach (int numero in numeros)
{
    if (numero > 10)
    {
        contador++;
    }
}

Console.WriteLine($"Quantidade de números maiores de 10: {contador}");