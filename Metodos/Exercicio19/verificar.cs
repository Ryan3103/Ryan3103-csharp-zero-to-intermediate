static bool PalavraGrande(string palavra)
{
    if (palavra.Length > 5)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool resultado = PalavraGrande("casa");
Console.WriteLine(resultado);