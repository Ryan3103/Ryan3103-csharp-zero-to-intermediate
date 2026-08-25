Console.WriteLine("Digite sua primeira nota: ");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite sua segunda nota: ");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite sua terceira nota: ");
double nota3 = double.Parse(Console.ReadLine());

double media = (nota1 + nota2 + nota3) / 3;

if (media <= 6)
    Console.WriteLine("Reprovado!");
else 
    Console.WriteLine("Aprovado!");

Console.WriteLine($"Sua média de notas é {media}");