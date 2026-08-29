Console.WriteLine("Digite um número: ");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número número: ");
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Qual operação? ");
string operacao = Console.ReadLine();

if (operacao == "+")
    Console.WriteLine(n1 + n2);
else if (operacao == "-")
    Console.WriteLine(n1 - n2);
else if (operacao == "*")
    Console.WriteLine(n1 * n2);
else if (operacao == "/")
    Console.WriteLine(n1 / n2);
else 
    Console.WriteLine("Operador invalido");