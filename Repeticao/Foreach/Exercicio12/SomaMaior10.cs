int[] numeros = { 4, 15, 8, 22, 7, 30, 11, 6 };

int soma = 0;

foreach (int numero in numeros)
{
    if(numero > 10)
    {
        soma += numero;
    }
}

Console.WriteLine($"Soma: {soma}");