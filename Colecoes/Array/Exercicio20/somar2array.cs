int[] numeros1 = new int[5];
int[] numeros2 = new int[5];
int[] resultado = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o {i + 1} número: 1");
    numeros1[i] = int.Parse(Console.ReadLine());

    Console.WriteLine($"Digite o {i + 1} número: 2");
    numeros2[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Resultado: ");

for (int i = 0; i < 5; i++)
{
    resultado[i] = numeros1[i] + numeros2[i];
    Console.Write($"{resultado[i]}  ");
}