class Conta
{
    public string NomeTitular;
    public decimal Saldo;

    public Conta(string nometitular, decimal saldo)
    {
        NomeTitular = nometitular;
        Saldo = saldo;
    }

    public void RegistrarMovimentacao(Movimentacao movimentacao)
    {
        if (movimentacao.EhEntrada == true)
        {
            Saldo += movimentacao.Valor;
        }
        else
        {
            Saldo -= movimentacao.Valor;
        }

        Movimentacoes.Add(movimentacao);
    }

    public List<Movimentacao> Movimentacoes = new List<Movimentacao>();

}