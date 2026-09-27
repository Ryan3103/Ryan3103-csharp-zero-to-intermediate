Console.WriteLine("Qual o valor da compra?");
double valor = double.Parse(Console.ReadLine());

double desconto1;
double desconto2;

desconto1 = valor * 0.10;
desconto2 = valor * 0.20;


if (valor <= 100) 
{
    Console.WriteLine("Sem desconto");
    Console.WriteLine("Total: " + valor);
}    

else if (valor <= 500)
{
    Console.WriteLine("Desconto 10%");
    Console.WriteLine(valor - desconto1);
}
else 
{
    Console.WriteLine("Desconto 20%");
    Console.WriteLine(valor - desconto2);
}