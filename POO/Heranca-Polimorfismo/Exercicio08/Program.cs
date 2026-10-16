List<Forma> formas = new List<Forma>();

formas.Add(new Retangulo(5, 3));
formas.Add(new Circulo(2));
formas.Add(new Retangulo(4, 4));
formas.Add(new Circulo(3));

foreach (Forma forma in formas)
{
    Console.WriteLine($"{forma.Nome} - Área: {forma.CalcularArea():F2}");
}