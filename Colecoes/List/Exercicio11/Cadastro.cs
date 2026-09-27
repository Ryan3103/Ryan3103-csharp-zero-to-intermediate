List<string> produtos = new List<string>();

produtos.Add("Mouse");
produtos.Add("Teclado");
produtos.Add("Monitor");
produtos.Add("Headset");
produtos.Add("Fone");

if (produtos.Contains("Mouse"))
{
    int posicao = produtos.IndexOf("Mouse");
    Console.WriteLine($"Posição: {posicao}");

    produtos.Remove("Mouse");
}

Console.WriteLine();
foreach (string produto in produtos)
{
    Console.WriteLine(produto);
}