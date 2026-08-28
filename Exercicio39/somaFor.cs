
int soma = 0;

for (int i = 1; i <= 10; i++) {
    Console.WriteLine("Digite um numero: ");
    int numero = int.Parse(Console.ReadLine());

    soma = soma + numero;
    }
    
    Console.WriteLine(soma);