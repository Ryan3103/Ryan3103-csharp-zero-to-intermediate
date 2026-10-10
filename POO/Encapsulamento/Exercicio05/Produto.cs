class Produto
{
    public string nome;
    private double preco;

    public Produto(string nome, double preco)
    {
        this.nome = nome;
        this.preco = preco;
    }

    public void AlterarPreco(double NovoPreco)
    {
        if (NovoPreco > 0)
        {
            preco = NovoPreco;
        }
    }
    public void AplicarDesconto(double percentual)
    {
        if (percentual >= 1 && percentual <= 50)
        {
            double desconto = preco * (percentual / 100);
            preco -= desconto;
        }
    }

    public void MostrarProduto()
    {
        Console.WriteLine($"Nome: {nome}, Preço: {preco:F2}");
    }
}