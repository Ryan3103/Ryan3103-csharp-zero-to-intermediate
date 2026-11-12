Produto produto1 = new Produto("Teclado", 200);

double desconto = produto1.CalcularDesconto(15);
Console.WriteLine($"Desconto: R$ {desconto:F2}");

double PrecoFinal = produto1.CalcularPrecoFinal(15);
Console.WriteLine($"Preço final: R$ {PrecoFinal:F2}");