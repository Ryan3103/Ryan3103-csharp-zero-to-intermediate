class Pessoa
{
    public string nome;
    public int idade;

    public void MostrarIdadeFutura(int anos)
    {
        int Novaidade = idade + anos;
        Console.WriteLine($"Daqui 5 anos, {nome} terá {Novaidade} anos.");
    }
}