Guerreiro guerreiro = new Guerreiro("Ryan", 100);
Mago mago = new Mago("Ana", 80);
Curadeiro curadeiro = new Curadeiro("Léo", 70);

List<Personagem> personagens = new List<Personagem>();

personagens.Add(guerreiro);
personagens.Add(mago);
personagens.Add(curadeiro);

// Exibindo a vida inicial
Console.WriteLine("=== Vida inicial ===");

foreach (Personagem personagem in personagens)
{
    Console.WriteLine($"{personagem.Nome}: {personagem.Vida} HP");
}

// Guerreiro ataca o Mago
Console.WriteLine("\n=== Combate ===");

int dano = guerreiro.Atacar();
mago.Vida = Math.Max(mago.Vida - dano, 0);

Console.WriteLine($"{guerreiro.Nome} atacou {mago.Nome}!");
Console.WriteLine($"Dano: {dano}");
Console.WriteLine($"Vida de {mago.Nome}: {mago.Vida} HP");

// Curandeiro cura o Mago
curadeiro.Curar(mago);

Console.WriteLine($"\n{curadeiro.Nome} curou {mago.Nome}!");
Console.WriteLine($"Vida de {mago.Nome}: {mago.Vida} HP");

// Exibindo o resultado final
Console.WriteLine("\n=== Estado final ===");

foreach (Personagem personagem in personagens)
{
    Console.WriteLine($"{personagem.Nome}: {personagem.Vida} HP");
}