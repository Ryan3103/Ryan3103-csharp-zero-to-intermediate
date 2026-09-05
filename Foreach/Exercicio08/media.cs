int[] numeros = { 8, 12, 20, 16, 24 };

int soma = 0;

foreach (int numero in numeros)
{
    soma += numero;
}

int media = soma / numeros.Length;

Console.WriteLine($"A média é: {media}");