class Guerreiro : Personagem
{
    public Guerreiro(string nome) : base(nome)
    {
    }

    public override int Atacar()
    {
        return 30;
    }
}