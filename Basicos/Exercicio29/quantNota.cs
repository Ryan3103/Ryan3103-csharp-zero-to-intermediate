Console.WriteLine("Digite um valor em reias: ");
int valor = int.Parse(Console.ReadLine());

int n100 = valor / 100;
valor %= 100;

int n50 = valor / 50;
valor %= 50;

int n20 = valor / 20;
valor %= 20;

int n10 = valor / 10;
valor %= 10;

int n5 = valor / 5;
valor %= 5;

int n2 = valor / 2;
valor %= 2;

int n1 = valor / 1;
valor %= 1;

Console.WriteLine(n100);
Console.WriteLine(n50);
Console.WriteLine(n20);
Console.WriteLine(n10);
Console.WriteLine(n5);
Console.WriteLine(n2);
Console.WriteLine(n1);