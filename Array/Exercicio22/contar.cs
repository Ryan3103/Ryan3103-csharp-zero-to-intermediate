int[] numeros = new int[10];

int positivo = 0;
int negativo = 0;
int zero = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número: ");
    numeros[i] = int.Parse(Console.ReadLine());

    if (numeros[i] > 0)
    {
        positivo++;
    }
    else if (numeros[i] < 0)
    {
        negativo++;
    }
    else
    {
        zero++;
    }
}

Console.WriteLine($"Positivos: {positivo}");
Console.WriteLine($"Negativos: {negativo}");
Console.WriteLine($"Zeros: {zero}");