List<string> nomes = new List<string>();

nomes.Add("Ryan");
nomes.Add("Gabriel");
nomes.Add("Silva");
nomes.Add("Breno");
nomes.Add("Leal");

Console.WriteLine("Antes: ");
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}

nomes.Remove("Breno");

Console.WriteLine();
Console.WriteLine("Depois: ");
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}
Console.WriteLine();
Console.WriteLine($"Quantidade: {nomes.Count}");