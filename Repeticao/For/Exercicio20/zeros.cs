int positivo = 0;
int negativo = 0;
int zeros = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Digite o {i}* número: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero > 0)
    {
        positivo++;
    }
    else if (numero < 0)
    {
        negativo++;
    }
    else if (numero == 0)
    {
        zeros++;
    }
}

Console.WriteLine($"Positivos: {positivo}");
Console.WriteLine($"Negativos: {negativo}");
Console.WriteLine($"Zeros: {zeros}");