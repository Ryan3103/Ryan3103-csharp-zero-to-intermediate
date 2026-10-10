class Personagem
{
    public string nome;
    private int vida;

    public Personagem(string nome, int vida)
    {
        this.nome = nome;
        this.vida = vida;
    }

    public void ReceberDano(int dano)
    {
        if (dano > 0)
        {
            vida -= dano;
        }
    }

    public void MostrarStatus()
    {
        Console.WriteLine($"Personagem: {nome}");
        Console.WriteLine($"Vida: {vida}");
    }
}