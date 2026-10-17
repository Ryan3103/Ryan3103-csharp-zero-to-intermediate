class EntregaExpressa : Entrega
{
    public EntregaExpressa(string destino, int diasbase) : base(destino, diasbase)
    {
    }

    public override int CalcularPrazo()
    {
        return DiasBase - 1;
    }
}