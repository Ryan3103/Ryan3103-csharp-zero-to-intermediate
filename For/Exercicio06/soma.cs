Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

int soma = 0;

for(int i = 1; i <= numero; i++)
{
    soma += i;
}

Console.WriteLine($"Soma: {soma}");