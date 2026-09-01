System.Console.WriteLine("Digite um numero: ");
int numero = int.Parse(Console.ReadLine());

int maior = 0;

while (numero != 0)
{
    if (numero > maior)
    {
        maior = numero;
    }

    System.Console.WriteLine("Digite um numero é: ");
    numero = int.Parse(Console.ReadLine());
}

System.Console.WriteLine($"Maior número {maior}!");