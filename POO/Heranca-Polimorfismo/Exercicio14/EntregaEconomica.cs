class EntregaEconomica : Entrega
{
    public EntregaEconomica(string destino, int diasbase) : base(destino, diasbase)
    {
    }

    public override int CalcularPrazo()
    {
        return DiasBase + 2;
    }
}