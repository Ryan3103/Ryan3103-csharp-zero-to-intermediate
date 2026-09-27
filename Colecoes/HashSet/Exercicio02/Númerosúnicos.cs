HashSet<int> numeros = new HashSet<int>();

for (int i = 1; i <= 8; i++)
{
    Console.WriteLine("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());
    
    numeros.Add(numero);
}

foreach (int numero in numeros)
{
    Console.WriteLine($"Todos os números únicos: {numero}");
}

Console.WriteLine($"Quantidade de números diferentes: {numeros.Count}");

Console.WriteLine("Digite um número para encontrar: ");
int numeros1 = int.Parse(Console.ReadLine());

if (numeros.Contains(numeros1))
{
    Console.WriteLine("Número encontrado!");
}
else
{
    Console.WriteLine("Número não encontrado!");
}