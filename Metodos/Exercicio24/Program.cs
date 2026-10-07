static int Dobro(int numero)
{
    return numero * 2;
}

static int SomarDobro(int numero1, int numero2)
{
    int dobro1 = Dobro(numero1);
    int dobro2 = Dobro(numero2);

    return dobro1 + dobro2;
}

int resultado = SomarDobro(5, 10);

Console.WriteLine(resultado);