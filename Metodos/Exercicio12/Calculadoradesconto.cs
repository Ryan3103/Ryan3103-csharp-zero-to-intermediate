static double CalcularDesconto(double preco, double desconto)
{
    double valorDesconto = preco * desconto / 100;

    double resultado = preco - valorDesconto;

    return resultado;
}
double resultado = CalcularDesconto(200, 10);

Console.WriteLine(resultado);