Console.WriteLine("Digite uma frase: ");
string frase = Console.ReadLine();

Console.WriteLine("Digite a palavra que quer substituir: ");
string palavra = Console.ReadLine();

Console.WriteLine("Digite a  nova palavra: ");
string novaPalavra = Console.ReadLine();

frase = frase.Replace(palavra, novaPalavra);

Console.WriteLine($"Frase substituida: {frase}");