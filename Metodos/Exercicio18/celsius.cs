static double CelsiusParaFahrenheit(double celsius)
{
    double Fahrenheit = celsius * 1.8 + 32;
    return Fahrenheit;
}

double resultado = CelsiusParaFahrenheit(30);
Console.WriteLine(resultado);