List<string> nomes = new List<string>();

nomes.Add("Ryan");
nomes.Add("Jesus");
nomes.Add("Breno");
nomes.Add("João");
nomes.Add("Matheus");

int posicao = nomes.IndexOf("Jesus");

if (posicao != -1)
{
    Console.WriteLine($"Jesus está na posicão {posicao}.");
}
else
    Console.WriteLine("Jesus não está na lista");