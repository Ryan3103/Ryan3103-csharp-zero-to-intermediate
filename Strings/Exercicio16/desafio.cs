Console.WriteLine("Digite uma frase: ");
string frase = Console.ReadLine();

Console.WriteLine($"Maiusculo: {frase.ToUpper()}");
Console.WriteLine($"Letras: {frase.Length}");

string [] palavras = frase.Split(" ");
Console.WriteLine($"Palavras: {palavras.Length}");
Console.WriteLine($"Primeira palavra: {palavras[0]}");
Console.WriteLine($"Ultima palavra: {palavras[palavras.Length -1]}");