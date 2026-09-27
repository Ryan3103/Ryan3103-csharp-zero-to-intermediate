System.Console.WriteLine("Digite suas notas: ");
double notas = double.Parse(Console.ReadLine());

int quantidade = 0;
double soma = 0;
double media;

while (notas != -1)
{   
    soma += notas;
    quantidade++;
    Console.WriteLine("Digite suas notas: ");
    notas = double.Parse(Console.ReadLine());
}

media = soma / quantidade;
System.Console.WriteLine(media);