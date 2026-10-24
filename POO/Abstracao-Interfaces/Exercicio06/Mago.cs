class Mago : Personagem
{
    public Mago(string nome, int vida) : base(nome, vida)
    {
    }

    public override int Atacar()
    {
        return 35;
    }
}