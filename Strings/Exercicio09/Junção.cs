Console.WriteLine("Digite uma frase: ");
string frase = Console.ReadLine();

frase = frase.Trim();
frase = frase.ToUpper();

string [] palavras = frase.Split(" ");

foreach (string palavra in palavras)
{
    Console.WriteLine(palavra);
}