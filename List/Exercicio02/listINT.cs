List<int> numeros = new List<int>();

int soma = 0;

numeros.Add(10);
numeros.Add(20);
numeros.Add(30);
numeros.Add(40);
numeros.Add(50);

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
    soma += numero;
}

Console.WriteLine($"Soma: {soma}");