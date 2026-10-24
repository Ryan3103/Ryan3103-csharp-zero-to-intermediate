class Curadeiro : Personagem, ICuravel
{
    public Curadeiro(string nome, int vida) : base(nome, vida)
    {
    }

    public override int Atacar()
    {
        return 10;
    }

    public void Curar(Personagem alvo)
    {
        alvo.Vida = Math.Min(alvo.Vida + 25, 100);
    }
}