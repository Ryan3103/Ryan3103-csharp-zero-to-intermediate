System.Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

int maior = 0;
int menor = numero;

while (numero != 0)
{
    if (numero > maior)
    {
        maior = numero;
    }
    else if (numero < menor)
    {
        menor = numero;
    }

    System.Console.WriteLine("Digite um número: ");
    numero = int.Parse(Console.ReadLine());
}

System.Console.WriteLine($"Maior: {maior}");
System.Console.WriteLine($"Menor: {menor}");