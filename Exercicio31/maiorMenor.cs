Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

if (numero < 0)
    Console.WriteLine("Número negativo!");
else if (numero > 0)
    Console.WriteLine("Número positivo!");
else 
    Console.WriteLine("Zero!");