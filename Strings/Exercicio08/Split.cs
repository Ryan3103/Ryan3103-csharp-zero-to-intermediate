Console.WriteLine("Digite uma frase: ");
string palavras = Console.ReadLine();

string [] frase = palavras.Split(" ");

foreach (string palavra in frase)
{
    Console.WriteLine(palavra);
}