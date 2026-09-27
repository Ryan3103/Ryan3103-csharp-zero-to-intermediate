Console.WriteLine("Digite um numero que deseje multiplicar: ");
int numero = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
    Console.WriteLine($"A multipicação de {numero} por {i} é: {numero * i}");