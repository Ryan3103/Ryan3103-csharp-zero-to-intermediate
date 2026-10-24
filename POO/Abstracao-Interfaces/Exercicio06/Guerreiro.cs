class Guerreiro : Personagem
{
    public Guerreiro(string nome, int vida) : base(nome, vida)
    {
    }

    public override int Atacar()
    {
        return 20;
    }
}