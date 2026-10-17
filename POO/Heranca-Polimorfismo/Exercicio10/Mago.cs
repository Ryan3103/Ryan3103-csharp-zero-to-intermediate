class Mago : Personagem
{
    public Mago(string nome) : base(nome)
    {
    }

    public override int Atacar()
    {
        return 50;
    }
}