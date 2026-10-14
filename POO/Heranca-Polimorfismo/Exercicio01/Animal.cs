class Animal
{
    public string Nome {get; protected set;} 

    public Animal(string nome)
    {
        Nome = nome;
    }

    public string EmitirSom()
    {
        return "Som genérico";
    }
}