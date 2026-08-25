Console.WriteLine("Digite o valor pago no produto: ");
double pago = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o preço do produto: ");
double preco = double.Parse(Console.ReadLine());

double troco = pago - preco;

Console.WriteLine($"Voce vai receber R${troco} de troco!");