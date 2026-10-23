List<Forma> formas = new List<Forma>();

formas.Add(new Retangulo(5, 3));
formas.Add(new Circulo(2));

foreach (Forma forma in formas)
{
    Console.WriteLine(forma.CalcularArea());
}