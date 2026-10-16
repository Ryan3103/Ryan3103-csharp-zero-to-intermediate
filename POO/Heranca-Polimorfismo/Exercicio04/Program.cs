List<Animal> animais = new List<Animal>();

animais.Add(new Cachorro("Rex"));
animais.Add(new Gato("Mimi"));
animais.Add(new Cachorro("Bob"));
animais.Add(new Animal("Animal genérico"));

foreach (Animal animal in animais)
{
    Console.WriteLine($"{animal.Nome} - {animal.EmitirSom()}");
}