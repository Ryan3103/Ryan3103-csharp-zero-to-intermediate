System.Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

int positivo = 0;
int soma = 0;

while (numero != 0)
{
    if (numero > 0)
    {
        positivo++;
        soma += numero;
    }

    System.Console.WriteLine("Digite um número: ");
    numero = int.Parse(Console.ReadLine());
}
double media = soma / positivo;

System.Console.WriteLine($"A soma dos números positivos é {soma}");
System.Console.WriteLine($"A média dos números positivos é {media}");