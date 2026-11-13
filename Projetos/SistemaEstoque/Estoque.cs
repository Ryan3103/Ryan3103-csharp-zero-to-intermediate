class Estoque
{
    List<Produto> produtos = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
    }
    public Produto BuscarProduto(string nome)
    {
        foreach (Produto produto in produtos)
        {
            if (produto.Nome == nome)
            {
                return produto;
            }
        }
        return null;
    }
    public void ExibirProdutos()
    {
        foreach (Produto produto in produtos)
        {
            Console.WriteLine($"{produto.Nome} - Preço: {produto.Preco} - Quantidade: {produto.QuantidadeEstoque}");
        }
    }
}