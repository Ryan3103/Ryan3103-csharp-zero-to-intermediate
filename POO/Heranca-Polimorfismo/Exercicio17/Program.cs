List<Produto> produtos = new List<Produto>();

produtos.Add(new Produto("Caderno", 30));
produtos.Add(new ProdutoPromocional("Fone", 150));
produtos.Add(new ProdutoPromocional("Mouse", 50));
produtos.Add(new ProdutoImportado("Teclado", 200));

foreach (Produto produto in produtos)
{
    Console.WriteLine($"{produto.Nome} - Preço final: R$ {produto.CalcularPrecoFinal():F2}");
}