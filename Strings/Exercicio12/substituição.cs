Console.WriteLine("Digite uma frase: ");
string frase = Console.ReadLine();

frase = frase.ToUpper();
frase = frase.Replace("A", "@");

Console.WriteLine(frase);