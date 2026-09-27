int contador = 0;

for(int i = 1; i <= 100; i++)
{
    if(i % 2 == 0)
    {
        contador++;
    }
}

Console.WriteLine($"Quantidade de pares: {contador}");