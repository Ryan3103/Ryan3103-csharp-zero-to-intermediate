class Pessoa
{
    public string nome;
    public int idade;

    public void VerificarIdade()
    {
        if (idade < 13)
        {
            Console.WriteLine("Criança");
        }
        else if (idade <= 17)
        {
            Console.WriteLine("Adolescente");
        }
        else
        {
            Console.WriteLine("Adulto");
        }
    }
}