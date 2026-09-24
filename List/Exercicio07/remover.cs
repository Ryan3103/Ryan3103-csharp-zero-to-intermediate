List<string> nomes = new List<string>();

nomes.Add("Ryan");
nomes.Add("Pedro");
nomes.Add("Joaquim");
nomes.Add("Walace");
nomes.Add("Junio");

nomes.RemoveAt(2);

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}