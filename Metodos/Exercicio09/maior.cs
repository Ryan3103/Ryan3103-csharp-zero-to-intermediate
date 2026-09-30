static int Maior(int numero1, int numero2)
{
    if (numero1 > numero2)
    {
        return numero1;
    }
    else
    {
        return numero2;
    }
}

int resultado = Maior(17, 9);

Console.WriteLine(resultado);