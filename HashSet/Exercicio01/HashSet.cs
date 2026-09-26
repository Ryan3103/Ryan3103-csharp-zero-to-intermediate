HashSet<string> nomes = new HashSet<string>();

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Digite um nome: ");
    string nome = Console.ReadLine();

    nomes.Add(nome);
}

foreach (string nom in nomes)
{
    Console.WriteLine($"Nomes: {nom}");
}

Console.WriteLine($"Quantidade de pessoas cadastradas: {nomes.Count}");

Console.WriteLine("Digite um nome: ");
string nome1 = Console.ReadLine();

if (nomes.Contains(nome1))
{
    Console.WriteLine("Pessoa cadastrada.");
}
else
{
    Console.WriteLine("Pessoa não cadastrada.");
}