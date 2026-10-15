Animal animal1 = new Animal("Animal genérico");
Animal animal2 = new Cachorro("Rex");
Animal animal3 = new Gato("Mimi");

Console.WriteLine(animal1.Nome);
Console.WriteLine(animal1.EmitirSom());

Console.WriteLine(animal2.Nome);
Console.WriteLine(animal2.EmitirSom());

Console.WriteLine(animal3.Nome);
Console.WriteLine(animal3.EmitirSom());