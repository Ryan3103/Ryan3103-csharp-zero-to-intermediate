Verificador v1 = new Verificador(6);

Console.WriteLine(v1.EhPar());              // True
Console.WriteLine(v1.EhPositivo());         // True
Console.WriteLine(v1.EhMultiploDeTres());   // True
Console.WriteLine(v1.ObterClassificacao()); // Positivo

Verificador v2 = new Verificador(-5);

Console.WriteLine(v2.EhPar());              // False
Console.WriteLine(v2.EhPositivo());         // False
Console.WriteLine(v2.EhMultiploDeTres());   // False
Console.WriteLine(v2.ObterClassificacao()); // Negativo

Verificador v3 = new Verificador(0);

Console.WriteLine(v3.EhPar());              // True
Console.WriteLine(v3.EhPositivo());         // False
Console.WriteLine(v3.EhMultiploDeTres());   // True
Console.WriteLine(v3.ObterClassificacao()); // Zero