int [] numeros = {18, 7, 25, 3, 14, 9};

int menor = numeros[0];

foreach (int numero in numeros)
{
    if(numero < menor)
    {
        menor = numero;
    }
}

Console.WriteLine($"O menor número é: {menor}");