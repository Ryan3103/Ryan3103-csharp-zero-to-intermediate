Console.WriteLine("1 - Celsius para Fahrenheit");
Console.WriteLine("2 - Fahrenheit para Celsius");

int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.Write("Digite a temperatura em Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit}°F");
        break;

    case 2:
        Console.Write("Digite a temperatura em Fahrenheit: ");
        double fahrenheit2 = double.Parse(Console.ReadLine());

        double celsius2 = (fahrenheit2 - 32) * 5 / 9;

        Console.WriteLine($"Temperatura em Celsius: {celsius2}°C");
        break;

    default:
        Console.WriteLine("Opção inválida!");
        break;
} 