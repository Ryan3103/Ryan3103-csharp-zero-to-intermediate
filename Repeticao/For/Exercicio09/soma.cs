int soma = 0;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());

    soma+=numero;
}

Console.WriteLine($"A soma dos números é: {soma}");