Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();

try
{
    Console.WriteLine("Digite sua idade: ");
    int idade = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite sua altura: ");
    double altura = double.Parse(Console.ReadLine());

    Console.WriteLine("Cadastro: ");
    Console.WriteLine(nome);
    Console.WriteLine(idade);
    Console.WriteLine(altura);
}
catch (FormatException)
{
    Console.WriteLine("Dados numéricos inválidos!");
}