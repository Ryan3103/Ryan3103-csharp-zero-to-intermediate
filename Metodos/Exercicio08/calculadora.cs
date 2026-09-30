static int Somar(int numero1, int numero2)
{
    int resultado = numero1 + numero2;

    return resultado;
}

static int Menos(int numero1, int numero2)
{
    int resultado = numero1 - numero2;

    return resultado;
}

static int Multiplicar(int numero1, int numero2)
{
    int resultado = numero1 * numero2;

    return resultado;
}

static int Dividir(int numero1, int numero2)
{
    int resultado = numero1 / numero2;

    return resultado;
}

int soma = Somar(20, 5);
int subtracao = Menos(20, 5);
int multiplicacao = Multiplicar(20, 5);
int dividir = Dividir(20, 5);

Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Subtração: {subtracao}");
Console.WriteLine($"Multiplicação: {multiplicacao}");
Console.WriteLine($"Divisão: {dividir}");