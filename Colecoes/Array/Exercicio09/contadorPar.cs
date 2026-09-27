int[] numeros = new int[10];

int contador = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i + 1} número: ");
    numeros[i] = int.Parse(Console.ReadLine());

    if (numeros[i] % 2 == 0)
    {
        contador++;
    }
}

Console.WriteLine($"Digitou {contador} números pares.");