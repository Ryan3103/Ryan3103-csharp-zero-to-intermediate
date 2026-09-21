List<string> nomes = new List<string>();

nomes.Add("Ryan");
nomes.Add("Ana");
nomes.Add("Pedro");
nomes.Add("Ethan");
nomes.Add("Junio");

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}

Console.WriteLine($"Quantidade: {nomes.Count}");