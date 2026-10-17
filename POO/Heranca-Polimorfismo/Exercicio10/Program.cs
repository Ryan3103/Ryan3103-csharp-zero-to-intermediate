List<Personagem> personagens = new List<Personagem>();

personagens.Add(new Guerreiro("Arthur"));
personagens.Add(new Mago("Merlin"));
personagens.Add(new Guerreiro("Lancelot"));
personagens.Add(new Mago("Morgana"));

foreach (Personagem personagem in personagens)
{
    Console.WriteLine($"{personagem.Nome} - Dano: {personagem.Atacar()}");
}