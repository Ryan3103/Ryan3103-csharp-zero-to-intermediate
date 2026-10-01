static string ClassificarIdade(int idade)
{
    if (idade <= 12)
    {
        return "Criança";
    }
    else if (idade <= 17)
    {
        return "Adolescente";
    }
    else if (idade <= 59)
    {
        return "Adulto";
    }
    else
    {
        return "Idoso";
    }
}

string resultado = ClassificarIdade(25);

Console.WriteLine(resultado);