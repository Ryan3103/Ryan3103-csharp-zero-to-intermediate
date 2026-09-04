int [] numeros = {5, 10, 15, 20, 25};

int soma = 0;

foreach (int numero in numeros)
{
    soma += numero;
}
Console.WriteLine($"A soma dos números é: {soma}");