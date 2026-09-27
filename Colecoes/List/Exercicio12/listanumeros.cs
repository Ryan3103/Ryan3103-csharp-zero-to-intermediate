int maior = 0;
int soma = 0;

List<int> numeros = new List<int>();

numeros.Add(10);
numeros.Add(20);
numeros.Add(30);
numeros.Add(40);
numeros.Add(50);
numeros.Add(60);
numeros.Add(70);
numeros.Add(80);
numeros.Add(90);
numeros.Add(100);

foreach (int numero in numeros)
{
    soma += numero;

    if (numero > maior)
    {
        maior = numero;
    }

    Console.WriteLine(numero);
}

Console.WriteLine($"Quantidade: {numeros.Count}");
Console.WriteLine($"Maior: {maior}");
Console.WriteLine($"Soma: {soma}");