Console.WriteLine("Digite um numero: ");
int numero = int.Parse(Console.ReadLine());

double soma = 0;
int contador = 0;
double media = 0;


while (numero != 0) {
    contador++;
    soma = soma + numero;
    numero = int.Parse(Console.ReadLine());
}

media = soma / contador;

Console.WriteLine("Quantidade: " + contador);
Console.WriteLine("Soma: " + soma);
Console.WriteLine("media: " + media);