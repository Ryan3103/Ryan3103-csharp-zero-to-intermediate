Console.WriteLine("Digite o primeiro número: ");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
int n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
    Console.WriteLine("O maior número é: " + n1);
else if (n1 < n2)
    Console.WriteLine("O maior número é: " + n2);
else 
    Console.WriteLine("Os números são iguais");