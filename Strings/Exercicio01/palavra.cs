Console.WriteLine("Digite uma palavra: ");
string palavra = Console.ReadLine();

Console.WriteLine($"Palavra em maiusculo: {palavra.ToUpper()}");
Console.WriteLine($"Palavra em minusculo: {palavra.ToLower()}");
Console.WriteLine($"Quantidade de caracteres: {palavra.Length}");