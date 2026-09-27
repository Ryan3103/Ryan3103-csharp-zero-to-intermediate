int [] numeros = new int [5];
int [] dobro = new int [5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o {i + 1} número: ");
    numeros[i] = int.Parse(Console.ReadLine());
    dobro[i] = numeros[i] * 2;
}

Console.WriteLine("O dobro dos números é: ");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(dobro[i]);
}