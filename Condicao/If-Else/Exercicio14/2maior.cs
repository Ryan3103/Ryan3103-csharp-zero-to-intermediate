Console.WriteLine("Digite um número: ");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número: ");
int n2 = int.Parse(Console.ReadLine());

if (n1 > n2) 
    Console.WriteLine($"O numero {n1} é maior!");
else 
    Console.WriteLine($"O numero {n2} é maior!");