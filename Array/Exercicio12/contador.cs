int[] numeros = new int[10];

int contador = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i + 1} número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Digite um número para encontra-lo: ");
int buscar = int.Parse(Console.ReadLine());

for (int i = 0; i < 10; i++)
{
    if (numeros[i] == buscar)
    {
        contador++;
    }
}

Console.WriteLine($"O número aparece {contador} vezes.");