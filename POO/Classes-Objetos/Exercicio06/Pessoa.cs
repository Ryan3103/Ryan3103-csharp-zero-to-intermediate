class Pessoa
{
    public string nome;
    public int idade;


    public void Apresentar()
    {
        Console.WriteLine($"Eu sou {nome} e tenho {idade} anos");
    }

    public void MudarNome(string novoNome)
    {
        nome = novoNome;
    }
}