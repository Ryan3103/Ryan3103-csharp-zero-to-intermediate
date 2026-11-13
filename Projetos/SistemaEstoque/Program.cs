Estoque estoque = new Estoque();

Produto produto1 = new Produto("Teclado", 150, 10);
Produto produto2 = new Produto("Mouse", 80, 15);
Produto produto3 = new Produto("Monitor", 900, 5);

estoque.AdicionarProduto(produto1);
estoque.AdicionarProduto(produto2);
estoque.AdicionarProduto(produto3);

estoque.ExibirProdutos();

Produto produtoEncontrado = estoque.BuscarProduto("Teclado");

if (produtoEncontrado != null)
{
    produtoEncontrado.AdicionarEstoque(5);
    produtoEncontrado.RemoverEstoque(2);
}

estoque.ExibirProdutos();

Produto produtoInexistente = estoque.BuscarProduto("Notebook");

if (produtoInexistente == null)
{
    Console.WriteLine("\nProduto não encontrado.");
}