Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite seu salario: ");
double salario = double.Parse(Console.ReadLine());

double aumento = (salario * 0.10);
double novoSalario = (salario + aumento);

Console.WriteLine("Funcionario: " + nome);
Console.WriteLine("Salario: " + salario);
Console.WriteLine("O seu aumento é: " + aumento);
Console.WriteLine("Seu novo salario é: " + novoSalario);