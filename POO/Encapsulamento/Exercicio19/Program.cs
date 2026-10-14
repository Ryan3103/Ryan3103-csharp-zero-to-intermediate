Calculadora calc = new Calculadora(10, 2);

Console.WriteLine($"Soma: {calc.Somar()}");
Console.WriteLine($"Subtração: {calc.Subtrair()}");
Console.WriteLine($"Multiplicação: {calc.Multiplicar()}");
Console.WriteLine($"Divisão: {calc.Dividir()}");

Calculadora calc2 = new Calculadora(10, 0);

Console.WriteLine($"Divisão por 0: {calc2.Dividir()}");