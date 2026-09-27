int opcao;

do
{
    System.Console.WriteLine("===== MENU =====");
    System.Console.WriteLine("1 - Dizer Olá");
    System.Console.WriteLine("2 - Mostrar número");
    System.Console.WriteLine("3 - Dizer Tchau");
    System.Console.WriteLine("4 - Sair");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Olá");
            break;

        case 2:
            Console.WriteLine("18");
            break;

        case 3:
            Console.WriteLine("Tchau!");
            break;

        case 4:
            Console.WriteLine("Saindo!");
            break;
    }
} while (opcao != 4);
Console.WriteLine("Finalizado!");