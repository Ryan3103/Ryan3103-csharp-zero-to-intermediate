int [] numeros = {4, 9, 12, 7, 20, 15, 8};

int contador = 0;
int soma = 0;

foreach (int numero in numeros)
{
    if (numero % 2 == 0)
    {
        contador++;
        soma += numero;
    }
}

Console.WriteLine($"Quantidade de pares: {contador}");
Console.WriteLine($"A soma dos números pares: {soma}");