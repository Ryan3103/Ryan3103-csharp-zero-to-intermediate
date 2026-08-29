Console.WriteLine("Digite seu nome: ");
string name = Console.ReadLine();

Console.WriteLine("Digite o nome do produto: ");
string produto = Console.ReadLine();

Console.WriteLine("Digite o preço do produto: ");
double preco = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de produto: ");
int quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("Forma de pagamento: ");
Console.WriteLine("1 - Dinheiro");
Console.WriteLine("2 - Cartão");
Console.WriteLine("3 - Pix");
int formaPagamento = int.Parse(Console.ReadLine());

double subTotal = preco * quantidade;
double desconto = 0;

// Desconto pelo valor da compra
if (subTotal <= 100)
    desconto = 0;
else if (subTotal <= 500)
    desconto = subTotal * 0.10;
else
    desconto = subTotal * 0.20;

double total = subTotal - desconto;

// Desconto pela forma de pagamento
if (formaPagamento == 1)
    total = total - (total * 0.05);
else if (formaPagamento == 2)
    total = total;
else if (formaPagamento == 3)
    total = total - (total * 0.03);
else
    Console.WriteLine("Forma de pagamento inválida!");

Console.WriteLine();
Console.WriteLine("===== RESUMO DA COMPRA =====");
Console.WriteLine("Cliente: " + name);
Console.WriteLine("Produto: " + produto);
Console.WriteLine("Quantidade: " + quantidade);
Console.WriteLine("Subtotal: R$" + subTotal);
Console.WriteLine("Desconto: R$" + desconto);
Console.WriteLine("Total: R$" + total);
Console.WriteLine("Forma de pagamento: " + formaPagamento);