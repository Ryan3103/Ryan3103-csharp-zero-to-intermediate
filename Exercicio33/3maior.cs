Console.WriteLine("Digite o primeiro número: ");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro número: ");
int n3 = int.Parse(Console.ReadLine());

if (n1 > n2 && n1 > n3)
    Console.WriteLine($"PRIMEIRO. O numero {n1} é maior!");
else if (n2 > n1 && n2 > n3)
    Console.WriteLine($"SEGUNDO. O numero {n2} é maior!");
else 
     Console.WriteLine($"TERCEIRO. O numero {n3} é maior!");