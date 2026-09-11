Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

bool primo = true;

for (int i = 2; i < numero; i++)
{
    if (numero % i == 0)
    {
        primo = false;
    }
}
if (primo)
{
    Console.WriteLine("Primo");
}
else
{
    Console.WriteLine("Não primo");
}