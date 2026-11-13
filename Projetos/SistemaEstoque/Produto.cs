class Produto
{
    public string Nome { get; private set; }
    public double Preco { get; private set; }
    public int QuantidadeEstoque { get; private set; }

    public Produto(string nome, double preco, int quantidadeEstoque)
    {
        Nome = nome;

        if (preco <= 0 || quantidadeEstoque < 0)
        {
            throw new ArgumentException("Valor inválido.");
        }
        Preco = preco;
        QuantidadeEstoque = quantidadeEstoque;
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade <= 0)
        {
            throw new ArgumentException("Quantidade inválida.");
        }
        QuantidadeEstoque += quantidade;
    }
    public void RemoverEstoque(int quantidade)
    {
        if (quantidade <= 0)
        {
            throw new ArgumentException("Quantidade inválida.");
        }
        if (quantidade > QuantidadeEstoque)
        {
            throw new ArgumentException("Estoque insuficiente.");
        }
        QuantidadeEstoque -= quantidade;
    }
}