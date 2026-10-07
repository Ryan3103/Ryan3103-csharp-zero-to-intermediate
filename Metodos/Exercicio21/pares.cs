static int ContarPares(int[] numeros)
{
    int contador = 0;

    foreach (int numero in numeros)
    {
        if (numero % 2 == 0)
        {
            contador++;
        }
    }
    return contador;
}

int[] numeros = { 2, 7, 4, 9, 10, 3 };
int resultado = ContarPares(numeros);

Console.WriteLine(resultado);