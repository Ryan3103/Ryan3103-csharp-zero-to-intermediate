static double CalcularMedia(double nota1, double nota2, double nota3)
{
    double media = (nota1 + nota2 + nota3) / 3;

    return media;
}

double resultado = CalcularMedia(7, 8, 9);

Console.WriteLine(resultado);