int opcao;

do
{
    System.Console.WriteLine("1 - Olá");
    System.Console.WriteLine("2 - Tchau");
    System.Console.WriteLine("3 - Sair");

    opcao = int.Parse(Console.ReadLine());

} while (opcao != 3);