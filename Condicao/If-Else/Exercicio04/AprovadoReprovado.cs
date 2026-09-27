Console.WriteLine("Digite a nota da sua prova: ");
double nota = double.Parse(Console.ReadLine());

if (nota >= 6) 
    Console.WriteLine("Aprovado!");
else 
    Console.WriteLine("Reprovado!");