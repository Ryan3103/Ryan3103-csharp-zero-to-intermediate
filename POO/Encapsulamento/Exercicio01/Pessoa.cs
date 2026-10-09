class Pessoa
{
    public string nome;
    private int idade;

    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public void MudarIdade(int novaIdade)
    {
        if (novaIdade >= 0)
        {
            this.idade = novaIdade;
        }
    }

    public void Apresentar()
    {
        Console.WriteLine($"Nome: {nome}, idade: {idade}");
    }
}