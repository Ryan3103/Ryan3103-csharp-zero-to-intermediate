int [] numeros = new int [10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i + 1} número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Números pares: ");
for (int i = 0; i < 10; i++)
{
    if (numeros[i] % 2 == 0)
    {
        Console.WriteLine(numeros[i]);
    }
}

Console.WriteLine("Números impares: ");
for (int i = 0; i < 10; i++)
{
    if (numeros[i] % 2 != 0)
    {
        Console.WriteLine(numeros[i]);
    }
}