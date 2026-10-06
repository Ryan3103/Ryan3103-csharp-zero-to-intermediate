static int Maiordetres (int numero1, int numero2, int numero3)
{
    if (numero1 >= numero2 && numero1 >= numero3)
    {
        return numero1;
    }
    else if (numero2 >= numero1 && numero2 >= numero3)
    {
        return numero2;
    }
    else
    {
        return numero3;
    }
}

int resultado = Maiordetres(10, 1, 20);
Console.WriteLine(resultado);