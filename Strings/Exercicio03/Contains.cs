Console.WriteLine("Digite uma frase: ");
string frase = Console.ReadLine();

Console.WriteLine("Digite uma palavra para procurar: ");
string palavra = Console.ReadLine();

if (frase.Contains(palavra))
{
    Console.WriteLine($"A palavra foi encontrada!");
}
else 
{
Console.WriteLine("A palavra não foi encontrada!");
}