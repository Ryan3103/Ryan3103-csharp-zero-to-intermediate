class Personagem
{
    public string Nome { get; protected set; }

    public Personagem(string nome)
    {
        Nome = nome;
    }

    public virtual int Atacar()
    {
        return 0;
    }
}