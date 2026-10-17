class Entrega
{
    public string Destino {get; protected set;}

    public int DiasBase {get; protected set;}

    public Entrega(string destino, int diasbase)
    {
        Destino = destino;
        DiasBase = diasbase;
    }

    public virtual int CalcularPrazo()
    {
        return DiasBase;
    }
}