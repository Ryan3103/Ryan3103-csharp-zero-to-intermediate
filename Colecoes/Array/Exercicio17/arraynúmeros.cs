int[] numeros1 = new int[5];
int[] numeros2 = new int[5];

int contador1 = 0;
int contador2 = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número do array 1:");
    numeros1[i] = int.Parse(Console.ReadLine());

    Console.WriteLine($"Digite o {i + 1}º número do array 2:");
    numeros2[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 5; i++)
{
    if (numeros1[i] % 2 == 0)
    {
        contador1++;
    }
    if (numeros2[i] % 2 == 0)
    {
        contador2++;
    }
}

if (contador1 > contador2)
{
    Console.WriteLine($"Array 1 tem mais pares: {contador1}");
}
else if (contador1 < contador2)
{
    Console.WriteLine($"Array 2 tem mais pares: {contador2}");
}
else
{
    Console.WriteLine($"Iguais: Array 1 = {contador1}, Array 2 = {contador2}");
}