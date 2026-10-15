class Gato : Animal
{
    public Gato(string nome) : base(nome)
    {
    }

    public override string EmitirSom()
    {
        return "Miau!";
    }
}