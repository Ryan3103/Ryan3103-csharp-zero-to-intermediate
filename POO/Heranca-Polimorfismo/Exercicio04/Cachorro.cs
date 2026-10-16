class Cachorro : Animal
{
    public Cachorro(string nome) : base(nome)
    {
    }

    public override string EmitirSom()
    {
        return "Au au!";
    }
}