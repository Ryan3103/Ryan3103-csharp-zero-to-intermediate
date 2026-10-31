CalculadoraDesconto calculadora = new CalculadoraDesconto();

Desconto descontoComum = new DescontoComum();
Desconto descontoVIP = new DescontoVIP();
Desconto descontoEstudante = new DescontoEstudante();

Console.WriteLine(calculadora.CalcularPrecoFinal(descontoComum, 100));
Console.WriteLine(calculadora.CalcularPrecoFinal(descontoVIP, 100));
Console.WriteLine(calculadora.CalcularPrecoFinal(descontoEstudante, 100));