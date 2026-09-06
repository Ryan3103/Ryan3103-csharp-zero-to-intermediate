int [] numeros = {7, 14, 3, 22, 9, 18, 5, 30};

int maior = numeros [0];
int menor = numeros [0];
int soma = 0;
int contador = 0;

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
    if (numero % 2 == 0)
    {
        soma += numero;
    }
    if (numero % 2 != 0)
    {
        contador++;
    }
}

Console.WriteLine($"Maior: {maior}");
Console.WriteLine($"Menor: {menor}");
Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Quantidade de números impares: {contador}");