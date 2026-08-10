Console.WriteLine("Nome do aluno: ");
string name = Console.ReadLine();

Console.WriteLine("Nota 1: ");
double n1 = double.Parse(Console.ReadLine());

Console.WriteLine("Nota 2: ");
double n2 = double.Parse(Console.ReadLine());

Console.WriteLine("Nota 3: ");
double n3 = double.Parse(Console.ReadLine());

double nota = n1 + n2 + n3;
double media = nota / 3;

Console.WriteLine("Nota 1: " + n1);
Console.WriteLine("Nota 2: " + n2);
Console.WriteLine("Nota 3: " + n3);
Console.WriteLine("Média: " + media);

if (media >= 7)
    Console.WriteLine("Aprovado!");
else if (media >= 5)
    Console.WriteLine("Recuperação!");
else 
    Console.WriteLine("Reprovado!");
