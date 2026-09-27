int[] numeros = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o {i + 1} número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Resultado:{numeros[i]}");
}