Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

int multiplicacao = 1;

for(int i = 1; i <= numero; i++)
{
    multiplicacao *= i;
}

Console.WriteLine($"!{numero} = {multiplicacao}");