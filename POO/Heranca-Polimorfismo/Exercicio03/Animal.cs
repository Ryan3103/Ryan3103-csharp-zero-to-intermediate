class Animal
{
    public string Nome { get; protected set; }

    public Animal(string nome)
    {
        Nome = nome;
    }

    public virtual string EmitirSom()
    {
        return "Som genérico";
    }
}