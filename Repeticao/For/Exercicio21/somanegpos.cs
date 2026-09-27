int positivos = 0;
int negativos = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Digite o {i}* número: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero > 0)
    {
        positivos += numero;
    }
    else if (numero < 0)
    {
        negativos += numero;
    }
}

Console.WriteLine($"Soma dos positivos: {positivos}");
Console.WriteLine($"Soma dos negativos: {negativos}");