try
{
    Console.WriteLine("Digite o preço do produto: ");
    double preco = double.Parse(Console.ReadLine());

    Console.WriteLine(preco);
}
catch (FormatException)
{
    Console.WriteLine("Preço inválido!");
}