List<string>nomes = new List<string>();

nomes.Add("Ryan");
nomes.Add("Pedro");
nomes.Add("Gustavo");
nomes.Add("Joaquim");
nomes.Add("Bruno");

nomes[3] = "Lucas";

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}