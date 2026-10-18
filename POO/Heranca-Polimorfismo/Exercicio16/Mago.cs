class Mago : Personagem
{
    public Mago(string nome) : base(nome)
    {
    }

    public override int CalcularDano(int forca)
    {
        return forca + 15;
    }
}