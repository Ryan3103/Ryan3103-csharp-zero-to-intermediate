int soma = 0;
int maior = 1;
int menor = 1;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());

    soma += numero;

    if (numero > maior)
    {
        maior = numero;
    }
    if (numero < menor)
    {
        menor = numero;
    }
}

Console.WriteLine($"Maior: {maior}");
Console.WriteLine($"Menor: {menor}");
Console.WriteLine($"Soma: {soma}");