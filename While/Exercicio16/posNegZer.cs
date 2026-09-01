System.Console.WriteLine("Digite um numero: ");
int numero = int.Parse(Console.ReadLine());

int positivos = 0;
int negativos = 0;
int zero = 0;

while (numero != 0)
{   
    if(numero > 0)
    {
        positivos++;
    }
    else if (numero < 0)
    {
        negativos++;
    }
    System.Console.WriteLine("Digite um numero: ");
    numero = int.Parse(Console.ReadLine());
}

System.Console.WriteLine($"Digitou {positivos} positivos");
System.Console.WriteLine($"Digitou {negativos} negativos");
System.Console.WriteLine($"Digitou {zero} zeros");