int funcionarios = 0;
double soma = 0;
double maior = 0;
string nomeMaior = "";
int mais2000 = 0;
int menos2000 = 0;

Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite seu salário: ");
double salario = double.Parse(Console.ReadLine());

while (salario != 0)
{
    funcionarios++;
    soma += salario;

    if (salario > maior)
    {
        maior = salario;
        nomeMaior = nome;
    }

    if (salario >= 2000)
    {
        mais2000++;
    }
    else
    {
        menos2000++;
    }

    Console.WriteLine("Digite seu nome: ");
    nome = Console.ReadLine();

    Console.WriteLine("Digite seu salário: ");
    salario = double.Parse(Console.ReadLine());
}

double media = soma / funcionarios;

Console.WriteLine($"Funcionários: {funcionarios}");
Console.WriteLine($"Soma dos salários: R${soma:F2}");
Console.WriteLine($"Salário médio: R${media:F2}");
Console.WriteLine($"Maior salário: {nomeMaior} - R${maior:F2}");
Console.WriteLine($"Salários >= R$ 2000: {mais2000}");
Console.WriteLine($"Salários < R$ 2000: {menos2000}");