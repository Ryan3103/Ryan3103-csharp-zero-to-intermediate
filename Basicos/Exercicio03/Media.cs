Console.WriteLine("Digite sua primeira nota: ");
double n1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite sua segunda nota: ");
double n2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite sua terceira nota: ");
double n3 = double.Parse(Console.ReadLine());

double media = (n1 + n2 + n3) / 3;

Console.WriteLine("Sua media de notas é: " + media);