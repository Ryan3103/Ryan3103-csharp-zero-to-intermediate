Console.WriteLine("Digite a temperatura em celsius: ");
int celsius = int.Parse(Console.ReadLine());

int fah = (celsius * 9 / 5) + 32;

Console.WriteLine($"A temperatura {celsius} em Fahrenheit é {fah}");