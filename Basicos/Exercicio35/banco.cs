Console.WriteLine("Digite um numero: ");
int numero = int.Parse(Console.ReadLine());

int n100 = numero / 100;
numero %= 100;

int n50 = numero / 50;
numero %= 50;

int n20 = numero / 20;
numero %= 20;

Console.WriteLine(n100);
Console.WriteLine(n50);
Console.WriteLine(n20);