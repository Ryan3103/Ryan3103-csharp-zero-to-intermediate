string palavra = Console.ReadLine();

string invertida = "";

for (int i = palavra.Length - 1; i >= 0; i--)
{
    invertida += palavra[i];
}

Console.WriteLine(invertida);