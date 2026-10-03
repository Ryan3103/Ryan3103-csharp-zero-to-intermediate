static int Contarvogais(string texto)
{
    int contador = 0;

    foreach (char letra in texto)
    {
        if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
        {
            contador++;
        }
    }
    return contador;
}

int resultado = Contarvogais("casa");

Console.WriteLine(resultado);