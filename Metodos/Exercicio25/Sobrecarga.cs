static int Multiplicar(int numero1, int numero2)
{
    return numero1 * numero2;
}

static int Multiplicar(int numero1, int numero2, int numero3)
{
    return numero1 * numero2 * numero3;
}

int resultado = Multiplicar(2, 5);
Console.WriteLine(resultado);