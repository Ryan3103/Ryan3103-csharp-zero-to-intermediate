Console.WriteLine("Digite a temperatura em celcius: ");
double cel = double.Parse(Console.ReadLine());

double F = (cel * 9 / 5) + 32;

Console.WriteLine($"A temperatura em F é {F}°F");
