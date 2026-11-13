class Evento
{
    public string Nome { get; private set; }
    public double Preco { get; private set; }
    public int IngressoDisponiveis { get; private set; }

    public Evento(string nome, double preco, int ingressoDisponiveis)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("Nome inválido.");
        }

        Nome = nome;

        if (preco <= 0)
        {
            throw new ArgumentException("Preço inválido.");
        }
        if (ingressoDisponiveis < 0)
        {
            throw new ArgumentException("Quantidade inválida.");
        }
        Preco = preco;
        IngressoDisponiveis = ingressoDisponiveis;
    }

    public bool ComprarIngresso(int quantidade)
    {
        if (quantidade <= 0)
        {
            return false;
        }
        if (IngressoDisponiveis < quantidade)
        {
            return false;
        }
        IngressoDisponiveis -= quantidade;

        return true;
    }

    public int ConsultarDisponibilidade()
    {
        return IngressoDisponiveis;
    }

    public double CalcularValorCompra(int quantidade)
    {
        return Preco * quantidade;
    }
}