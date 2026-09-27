System.Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

int soma = 0;

while (numero != 0)
{
    soma += numero;

    System.Console.WriteLine("Digite um número: ");
    numero = int.Parse(Console.ReadLine());
}

Console.WriteLine(soma);