Console.WriteLine("Digite um número: ");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número: ");
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a operação: ( +, -, *, /)");
string operacao = Console.ReadLine();

int resultado;

if (operacao == "+") {
    resultado = n1 + n2;
}
else if (operacao == "-") {
    resultado = n1 - n2;
}
else if (operacao == "*") {
    resultado = n1 * n2;
}
else if (operacao == "/") {
    resultado = n1 / n2;
}
else {
    Console.WriteLine("Operação inválida!");
    return;
}

Console.WriteLine($"resultado: {resultado}");