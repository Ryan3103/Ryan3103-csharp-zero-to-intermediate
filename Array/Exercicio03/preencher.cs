int [] numeros = new int [5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite um número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Resultado: ");

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}