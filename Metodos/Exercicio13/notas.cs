static string VerificarSituacao(double media)
{
    if (media >= 6)
    {
        return "aprovado";
    }
    else
    {
        return "reprovado";
    }
}

string resultado = VerificarSituacao(7.5);

Console.WriteLine(resultado);