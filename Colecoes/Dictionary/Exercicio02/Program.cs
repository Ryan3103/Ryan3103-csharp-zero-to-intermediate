Dictionary<string, int> produto = new Dictionary<string, int>();

int total = 0;
int maior = 0;
string maisCaro = "";

produto.Add("Caderno", 20);
produto.Add("Mochila", 100);
produto.Add("Caneta", 2);
produto.Add("Borracha", 1);
produto.Add("Corretivo", 2);

foreach (KeyValuePair<string, int> item in produto)
{
    total += item.Value;

    if (item.Value > maior)
    {
        maior = item.Value;
        maisCaro = item.Key;
    }

    Console.WriteLine($"Nome: {item.Key} - Preço: {item.Value}");
}
Console.WriteLine($"Total: {total}");
Console.WriteLine($"Maior: {maior} - {maisCaro}");