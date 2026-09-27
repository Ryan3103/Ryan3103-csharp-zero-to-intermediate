System.Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

int positivos = 0;
int soma = 0;

while (numero != 0)
{
    if (numero > 0)
    {
        positivos++;
        soma += numero;
    }
    System.Console.WriteLine("Digite um número: ");
    numero = int.Parse(Console.ReadLine());
}

System.Console.WriteLine($"A soma dos {positivos} positivos é {soma}.");