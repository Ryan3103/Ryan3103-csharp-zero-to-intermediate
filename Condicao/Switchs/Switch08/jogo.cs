double suaVida = 100;
double vidaInimigo = 100;

Console.WriteLine($"Sua vida: {suaVida}");
Console.WriteLine($"Vida do inimigo: {vidaInimigo}");

Console.WriteLine();
Console.WriteLine("1 - Atacar");
Console.WriteLine("2 - Defender");
Console.WriteLine("3 - Usar poção");
Console.WriteLine("4 - Fugir");

Console.Write("Escolha uma ação: ");
int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        vidaInimigo -= 20;

        Console.WriteLine("Você atacou!");
        Console.WriteLine("O inimigo perdeu 20 de vida.");
        Console.WriteLine($"Vida do inimigo: {vidaInimigo}");

        if (vidaInimigo <= 0)
        {
            Console.WriteLine("Você venceu!");
        }
        else
        {
            Console.WriteLine("O inimigo ainda está vivo!");
        }
        break;

    case 2:
        if (suaVida < 100)
        {
            suaVida += 10;

            if (suaVida > 100)
            {
                suaVida = 100;
            }

            Console.WriteLine("Você se defendeu e recuperou 10 de vida!");
            Console.WriteLine($"Sua vida: {suaVida}");
        }
        else
        {
            Console.WriteLine("Sua vida já está cheia!");
        }
        break;

    case 3:
        if (suaVida < 100)
        {
            suaVida += 30;

            if (suaVida > 100)
            {
                suaVida = 100;
            }

            Console.WriteLine("Você usou uma poção!");
            Console.WriteLine($"Sua vida: {suaVida}");
        }
        else
        {
            Console.WriteLine("Sua vida já está cheia!");
        }
        break;

    case 4:
        Console.WriteLine("Você fugiu da batalha!");
        break;

    default:
        Console.WriteLine("Opção inválida!");
        break;
}