int[] numeros = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o {i + 1} número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Digite o número que quer encontrar: ");
int busca = int.Parse(Console.ReadLine());

bool encontrar = false;

for (int i = 0; i < 5; i++)
{
    if (numeros[i] == busca)
    {
        encontrar = true;
    }
}

if (encontrar)
{
    Console.WriteLine("Número encontrado!");
}
else
{
    Console.WriteLine("Número não encontrado!");
}