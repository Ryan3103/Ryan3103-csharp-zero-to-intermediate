Pagamento pagamento1 = new PagamentoPix(150m);
Pagamento pagamento2 = new PagamentoCartao(250m);

Console.WriteLine(pagamento1.RealizarPagamento());
Console.WriteLine(pagamento2.RealizarPagamento());