class Personagem
{
    public string Nome {get; protected set;}

    public Personagem(string nome)
    {
        Nome = nome;
    }

    public virtual int CalcularDano(int forca)
    {
        return forca;
    }
}