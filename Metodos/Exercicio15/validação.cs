static bool Validarsenha(string senha)
{
    if (senha != "123456789")
    {
        return false;
    }
    else
    {
        return true;
    }
}

bool resultado = Validarsenha("123456789");

Console.WriteLine(resultado);