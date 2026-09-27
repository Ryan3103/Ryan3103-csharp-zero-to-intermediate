System.Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

int maior = numero;

while (numero != 0)
{
    System.Console.WriteLine("Digite um número: ");
    numero = int.Parse(Console.ReadLine());

    if (numero > maior)
    {
        maior = numero;
    }
}
System.Console.WriteLine(maior);