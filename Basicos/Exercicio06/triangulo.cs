Console.WriteLine("Digite a base: ");
int bas = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a altura: ");
int altura = int.Parse(Console.ReadLine());

int area = (bas * altura);
int perimetro = 2 *  (bas + altura);

Console.WriteLine(area);
Console.WriteLine(perimetro);