class Guerreiro : Personagem
{
    public Guerreiro(string nome) : base(nome)
    {
    }

    public override int CalcularDano(int forca)
    {
        return forca * 2;
    }
}