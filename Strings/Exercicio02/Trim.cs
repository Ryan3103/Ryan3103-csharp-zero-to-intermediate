Console.WriteLine("Digite uma palavra com espaço no começo: ");
string palavraOriginal = Console.ReadLine();

Console.WriteLine($"Original: {palavraOriginal}");
Console.WriteLine($"Com trim: {palavraOriginal.Trim()}");