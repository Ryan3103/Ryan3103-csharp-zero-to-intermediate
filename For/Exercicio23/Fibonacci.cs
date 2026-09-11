int a = 0;
int b = 1;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(a);

    int resultado = a + b;
    a = b;
    b = resultado;
}