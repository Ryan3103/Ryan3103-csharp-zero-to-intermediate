int [] numeros = {4, 7, 10, 13, 16, 21, 24};

int contador = 0;

foreach (int numero in numeros)
{
    if (numero % 2 == 0){
        contador++;
    }
}

Console.WriteLine($"A quantidade de números pares é: {contador}");