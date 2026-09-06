int [] numeros = {5, 12, 7, 20, 3, 18, 10, 25};

double soma = 0;
int contador = 0;
double media;

foreach (int numero in numeros)
{
    if (numero > 10)
    {
        contador++;
        soma += numero;
    }
}

media = soma / contador;

Console.WriteLine($"Média: {media}");