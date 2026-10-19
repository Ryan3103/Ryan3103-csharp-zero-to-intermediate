class Movimentacao
{
    public string Descricao;
    public decimal Valor;
    public bool EhEntrada;

    public Movimentacao(string descricao, decimal valor, bool ehentrada)
    {
        Descricao = descricao;
        Valor = valor;
        EhEntrada = ehentrada;
    }
}