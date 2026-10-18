List<Personagem> personagens = new List<Personagem>();

personagens.Add(new Personagem("Aventureiro"));
personagens.Add(new Guerreiro("Thor"));
personagens.Add(new Mago("Merlin"));

foreach (Personagem personagem in personagens)
{
    Console.WriteLine($"{personagem.Nome} - Dano: {personagem.CalcularDano(10)}");
}