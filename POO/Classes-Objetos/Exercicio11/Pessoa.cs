class Pessoa
{
    public string nome;
    public int idade;

    public void VerificarMaioridade()
    {
        if (idade >= 18)
        {
            Console.WriteLine($"{nome} é maior de idade");
        }
        else
        {
            Console.WriteLine($"{nome} é menor de idade");
        }
    }
}