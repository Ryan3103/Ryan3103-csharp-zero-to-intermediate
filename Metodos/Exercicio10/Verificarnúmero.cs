static bool Ehpar (int numero)
{
    if (numero % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool resultado = Ehpar(10);

Console.WriteLine(resultado);