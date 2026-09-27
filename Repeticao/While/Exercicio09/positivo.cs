System.Console.WriteLine("Digite números postivos e negativos: ");
int numero = int.Parse(Console.ReadLine());

int positivos = 0;

while (numero != 0)
{
    if (numero > 0)
    {
        positivos++;
    }
     System.Console.WriteLine("Digite outro numero: ");
     numero = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Quantidade de positivos: {positivos}");