List<Pagamento> pagamentos = new List<Pagamento>();

pagamentos.Add(new PagamentoPix(100));
pagamentos.Add(new PagamentoCartao(100));
pagamentos.Add(new PagamentoPix(250));
pagamentos.Add(new PagamentoCartao(250));

foreach (Pagamento pagamento in pagamentos)
{
    Console.WriteLine($"R$ {pagamento.CalcularValorFinal():F2}");
}