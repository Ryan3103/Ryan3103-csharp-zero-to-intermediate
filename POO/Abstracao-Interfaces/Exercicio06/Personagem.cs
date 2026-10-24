abstract class Personagem
{
    public string Nome { get; set; }
    public int Vida { get; set; }

    public Personagem(string nome, int vida)
    {
        Nome = nome;
        Vida = vida;
        Vida = Math.Clamp(vida, 0, 100);
    }

    public abstract int Atacar();
}