Console.WriteLine("Digite uma palavra: ");
string palavra = Console.ReadLine();

Console.WriteLine($"Primeira letra: {palavra[0]}");
Console.WriteLine($"Ultima letra: {palavra[palavra.Length - 1]}");