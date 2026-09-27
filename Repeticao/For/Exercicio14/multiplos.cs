int contador = 0;

for(int i = 1; i <= 100; i++)
{
    if(i % 3 == 0)
    {
        contador++;
    }
}

Console.WriteLine($"Quantidade de multiplos de 3: {contador}");