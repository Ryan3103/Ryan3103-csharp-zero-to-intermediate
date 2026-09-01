System.Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

int menor = numero;

while (numero != 0)
{
    if (numero < menor)
    {
        menor = numero;
    }
    System.Console.WriteLine("Digite um número: ");
    numero = int.Parse(Console.ReadLine());
}

System.Console.WriteLine($"O menor número é {menor}");