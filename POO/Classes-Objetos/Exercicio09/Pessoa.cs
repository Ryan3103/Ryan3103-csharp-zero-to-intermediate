class Pessoa
{
    public string nome;
    public int idade;

    public void MostrarIdadeEmMeses()
    {
        int meses = idade * 12;

        Console.WriteLine($"Idade em meses: {meses}");
    }
}