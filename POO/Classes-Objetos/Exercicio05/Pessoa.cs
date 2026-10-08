class Pessoa
{
    public string nome;
    public int idade;

    public void Apresentar()
    {
        Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos");
    }
    public void FazerAniversario()
    {
        idade++;
    }
}