Dictionary<string, double> produto = new Dictionary<string, double>();

produto.Add("Caderno", 20);
produto.Add("Mochila", 100);
produto.Add("Caneta", 2);
produto.Add("Borracha", 1.90);
produto.Add("Corretivo", 2.99);

Console.WriteLine("Digite um nome de produto: ");
string nome = Console.ReadLine();

if (produto.ContainsKey(nome))
{
    Console.WriteLine($"Produto encontrado. Preço: R$:{produto[nome]:F2}");
}
else
{
    Console.WriteLine("Produto não encontrado.");
}