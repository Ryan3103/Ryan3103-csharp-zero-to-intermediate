Console.WriteLine("Digite um número inteiro: ");
int numero = int.Parse(Console.ReadLine());

if (numero > 0) 
    Console.WriteLine("Positivo!");
else if (numero < 0) 
    Console.WriteLine("Negativo!");
else 
    Console.WriteLine("Zero!");