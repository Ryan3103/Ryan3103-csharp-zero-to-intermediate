Console.WriteLine("Digite o valor da compra: ");
double valorCompra = double.Parse(Console.ReadLine());

double frete;
double total;

if (valorCompra <= 100)
    frete = 20;
else 
    frete = 10;

   total = valorCompra + frete;

   Console.WriteLine("Valor da compra: " + valorCompra);
    Console.WriteLine("frete: " + frete);
     Console.WriteLine("Total: " + total);