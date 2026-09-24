List<string> nomes = new List<string>();

nomes.Add("Ryan");
nomes.Add("Pedro");
nomes.Add("Matheus");
nomes.Add("Jacó");

nomes.Insert(1, "Carlos");

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}