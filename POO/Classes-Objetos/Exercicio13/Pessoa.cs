class Pessoa
{
    public string nome;
    public int idade;

    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public void Apresentar()
    {
        Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos.");
    }
}