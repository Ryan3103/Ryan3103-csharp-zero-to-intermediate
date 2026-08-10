Console.WriteLine("Digite seu nome: ");
string name = Console.ReadLine();

Console.WriteLine("Digite seu salário: ");
double salario = double.Parse(Console.ReadLine());

double bonus;
double salarioFinal;

if (salario <= 2000)
bonus = 0.10;
else
bonus = 0.05;

```
salarioFinal = salario + bonus;

Console.WriteLine("Salario: " + salario);
 Console.WriteLine("Bonus: " + bonus);
  Console.WriteLine("Salario final: " + salarioFinal);