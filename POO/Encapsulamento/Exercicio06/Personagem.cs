class Personagem
{
    public string nome;
    private int vida;

    public Personagem (string nome, int vida)
    {
        this.nome = nome;
        this.vida = vida;
    }

    public void ReceberDano (int dano)
    {
        if (dano > 0)
        {
            vida -= dano;

            if (vida < 0)
            {
                vida = 0;
            }
        }
    }

    public void Curar(int quantidade)
    {
        if (quantidade > 0)
        {
            vida += quantidade;

            if (vida > 100)
            {
                vida = 100;
            }
        }
    }

    public void MostrarStatus()
    {
        Console.WriteLine($"Personagem: {nome}");
        Console.WriteLine($"Vida: {vida}");
    }
}