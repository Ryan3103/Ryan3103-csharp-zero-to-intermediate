List<string> nomes = new List<string>();

nomes.Add("Ryan");
nomes.Add("Pedro");
nomes.Add("Gabriel");
nomes.Add("Junio");
nomes.Add("Silva");

Console.WriteLine($"Primeiro: {nomes[0]}");
Console.WriteLine($"Terceiro: {nomes[2]}");
Console.WriteLine($"Ultimo: {nomes[nomes.Count - 1]}");