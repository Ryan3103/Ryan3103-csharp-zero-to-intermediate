try
{
    Console.WriteLine("Digite o primeiro número: ");
    int numero1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo número: ");
    int numero2 = int.Parse(Console.ReadLine());

    double divisao = numero1 / numero2;

    Console.WriteLine($"Resultado: {divisao}");
}
catch (FormatException)
{
    Console.WriteLine("Número inválido!");
}

catch (DivideByZeroException)
{
    Console.WriteLine("Não é possivel dividir por zero!");
}