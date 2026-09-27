System.Console.WriteLine("Digite o número secreto: ");
int numero = int.Parse(Console.ReadLine());

while (numero != 7)
{
    if (numero > 7)
    {
        System.Console.WriteLine("Chutou acima do número secreto!");
    }
    else
    System.Console.WriteLine("Chutou abaixo do número secreto!");

    System.Console.WriteLine("tente novamente: ");
    numero = int.Parse(Console.ReadLine());
}

System.Console.WriteLine("Voce acertou o número secreto: " + numero);