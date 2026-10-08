class Pessoa
{
    public string nome;
    public int idade;

    public void Apresentar()
    {
        Console.WriteLine($"Meu nome é {nome} tenho {idade} anos");
    }

    public void MudarDados(string Novonome,int Novaidade)
    {
        nome = Novonome;
        idade = Novaidade;
    }
}