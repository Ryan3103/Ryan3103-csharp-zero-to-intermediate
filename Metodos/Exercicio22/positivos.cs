static int SomarPositivos(int[] numeros)
{
    int soma = 0;

    foreach (int numero in numeros)
    {
        if (numero > 0)
        {
            soma += numero;
        }
    }
    return soma;
}

int[] numeros = { 5, -2, 10, -8, 3 };
int resultado = SomarPositivos(numeros);

Console.WriteLine(resultado);