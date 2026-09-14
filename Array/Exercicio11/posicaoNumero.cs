int[] numeros = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o {i + 1} número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Digite o número procurado: ");
int buscar = int.Parse(Console.ReadLine());

bool encontra = false;
int posicao = -1;

for (int i = 0; i < 5; i++)
{
    if (numeros[i] == buscar)
    {
        encontra = true;
        posicao = i;
    }
}

if (encontra)
{
    Console.WriteLine($"Encontrado na posição: {posicao}");
}
else
{
    Console.WriteLine("Número não encontrado: ");
}