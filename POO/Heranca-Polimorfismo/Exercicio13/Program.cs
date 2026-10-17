List<Produto> produtos = new List<Produto>();

produtos.Add(new ProdutoFisico("Teclado", 100));
produtos.Add(new ProdutoDigital("E-book", 50));
produtos.Add(new ProdutoFisico("Mouse", 80));
produtos.Add(new ProdutoDigital("Curso online", 200));


foreach (Produto produto in produtos)
{
    Console.WriteLine($"{produto.Nome} - Preço final: R$ {produto.CalcularPrecoFinal():F2}");
}