Console.WriteLine("Digite o nome do produto: ");
string produto = Console.ReadLine();

Console.WriteLine("Digite o preço do produto: ");
double preco = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade: ");
int quant = int.Parse(Console.ReadLine());

double total = (preco * quant);


Console.WriteLine("Produto: " + produto);
Console.WriteLine("Quantidade: " + quant);
Console.WriteLine("Total: R$" + total);