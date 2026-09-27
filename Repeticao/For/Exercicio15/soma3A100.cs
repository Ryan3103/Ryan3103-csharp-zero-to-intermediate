int soma = 0;

for(int i = 1; i <= 100; i++)
{
    if(i % 3 == 0)
    {
        soma += i;
    }
}

Console.WriteLine($"Soma dos multiplos de 3: {soma}");