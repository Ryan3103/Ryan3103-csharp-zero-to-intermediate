Console.WriteLine("Digite uma palavra: ");
string palavra = Console.ReadLine();

Console.WriteLine(palavra.Length);
Console.WriteLine($"3 primeiros caracteres: {palavra.Substring(0, 3)}");
Console.WriteLine($"3 ultimos caracteres: {palavra.Substring(palavra.Length -3, 3)}");