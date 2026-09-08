Console.WriteLine("DIgite uma frase: ");
string frase = Console.ReadLine();

frase = frase.ToUpper();
string [] palavra = frase.Split(" ");

foreach (string tudo in palavra)
{
    Console.WriteLine(tudo);
}