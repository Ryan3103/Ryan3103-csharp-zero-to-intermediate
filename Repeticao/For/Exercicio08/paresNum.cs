Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

for (int i = 1; i <= numero; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}