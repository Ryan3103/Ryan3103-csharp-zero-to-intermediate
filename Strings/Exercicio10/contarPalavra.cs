Console.WriteLine("Digite uma frase: ");
string frase = Console.ReadLine();

string [] palavras = frase.Split(" ");
Console.WriteLine($"Quantidade de palavras: {palavras.Length}");