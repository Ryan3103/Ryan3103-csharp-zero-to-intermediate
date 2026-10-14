Retangulo r1 = new Retangulo(5, 3);

Console.WriteLine("=== Retângulo 1 ===");
Console.WriteLine($"Área: {r1.CalcularArea()}");
Console.WriteLine($"Perímetro: {r1.CalcularPerimetro()}");
Console.WriteLine($"É quadrado? {r1.EhQuadrado()}");
Console.WriteLine(r1.ObterDescricao());

Retangulo r2 = new Retangulo(4, 4);

Console.WriteLine("\n=== Retângulo 2 ===");
Console.WriteLine($"Área: {r2.CalcularArea()}");
Console.WriteLine($"Perímetro: {r2.CalcularPerimetro()}");
Console.WriteLine($"É quadrado? {r2.EhQuadrado()}");
Console.WriteLine(r2.ObterDescricao());

Retangulo r3 = new Retangulo(-2, 3);

Console.WriteLine("\n=== Retângulo 3 ===");
Console.WriteLine($"Área: {r3.CalcularArea()}");
Console.WriteLine($"Perímetro: {r3.CalcularPerimetro()}");
Console.WriteLine($"É quadrado? {r3.EhQuadrado()}");
Console.WriteLine(r3.ObterDescricao());

Retangulo r4 = new Retangulo(0, -5);

Console.WriteLine("\n=== Retângulo 4 ===");
Console.WriteLine($"Área: {r4.CalcularArea()}");
Console.WriteLine($"Perímetro: {r4.CalcularPerimetro()}");
Console.WriteLine($"É quadrado? {r4.EhQuadrado()}");
Console.WriteLine(r4.ObterDescricao());
