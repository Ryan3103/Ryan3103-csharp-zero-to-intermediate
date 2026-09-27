Console.WriteLine("Digite o preço do produto: ");
double preco = double.Parse(Console.ReadLine());

double desconto1 = preco * 0.10;
double desconto2 = preco * 0.15;

double npreco1 = preco - desconto1;
double npreco2 = preco - desconto2;

if (preco <= 100)
    Console.WriteLine("Sem desconto!");
else if (preco <= 300)
    Console.WriteLine($"O desconto é R${desconto1} e o novo preço é R${npreco1}");
else 
    Console.WriteLine($"O desconto é R${desconto2} e o novo preço é R${npreco2}");