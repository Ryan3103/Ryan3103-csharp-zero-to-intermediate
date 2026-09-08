Console.WriteLine("Digite uma palavra: ");
string palavra = Console.ReadLine();

int contador = 0;

foreach (char letra in palavra)
{
    if (letra == 'a')
    {
        contador++;
    }
}

Console.WriteLine($"A letra 'a' aparece {contador} vezes.");