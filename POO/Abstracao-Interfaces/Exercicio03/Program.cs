List<Pagamento> pagamentos = new List<Pagamento>();

pagamentos.Add(new Cartao(100));
pagamentos.Add(new Pix(200));

foreach (Pagamento pagamento in pagamentos)
{
    Console.WriteLine($"Valor: {pagamento.Valor}");
    Console.WriteLine($"Taxa: {pagamento.CalcularTaxa()}");
    pagamento.Processar();
}