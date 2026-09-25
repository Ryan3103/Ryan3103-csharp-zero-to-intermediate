int contador = 0;
double soma = 0;
double maior = 0;
int maiscem = 0;
int menoscem = 0;
string nomeMaior = "";

Console.WriteLine("Digite o nome do produto: ");
string nome = Console.ReadLine();
Console.WriteLine("Digite o preço do produto: ");
double preco = double.Parse(Console.ReadLine());

while (preco != 0)
{
    soma += preco;
    contador++;

    if (preco > maior)
    {
        maior = preco;
        nomeMaior = nome;
    }
    if (preco >= 100)
    {
        maiscem++;
    }
    else if (preco < 100)
    {
        menoscem++;
    }
    Console.WriteLine("Digite o nome do produto: ");
    nome = Console.ReadLine();
    Console.WriteLine("Digite o preço do produto: ");
    preco = double.Parse(Console.ReadLine());

}

Console.WriteLine($"Produtos cadastrados: {contador}");
Console.WriteLine($"Valor total: R${soma:F2}");
Console.WriteLine($"Produto mais caro: {nomeMaior} - R${maior:F2}");
Console.WriteLine($"Produtos >= 100: {maiscem}");
Console.WriteLine($"Produtos < 100: {menoscem}");