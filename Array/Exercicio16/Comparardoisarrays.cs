int [] numeros1 = new int [5];
int [] numeros2 = new int [5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o {i + 1} número array1: ");
    numeros1[i] = int.Parse(Console.ReadLine());

    Console.WriteLine($"Digite o {i + 1} número array2: ");
    numeros2[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 5; i++)
{
    if (numeros1[i] > numeros2[i])
    {
        Console.WriteLine($"{numeros1[i]} é maior");
    }
    else if (numeros1[i] < numeros2[i])
    {
        Console.WriteLine($"{numeros2[i]} é maior");
    }
    else
    {
        Console.WriteLine("iguais");
    }
}