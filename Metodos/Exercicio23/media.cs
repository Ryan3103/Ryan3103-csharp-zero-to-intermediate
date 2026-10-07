static int CalcularMedia(int[] numeros)
{
    int contador = 0;
    int soma = 0;

    foreach (int numero in numeros)
    {
        contador++;
        soma += numero;
    }
    return soma / contador;
}
int[] numeros = { 10, 20, 30, 40 };

int resultado = CalcularMedia(numeros);

Console.WriteLine(resultado);