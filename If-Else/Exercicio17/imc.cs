Console.WriteLine("Digite seu peso: ");
double peso = double.Parse(Console.ReadLine());

Console.WriteLine("Digite sua altura: ");
double altura = double.Parse(Console.ReadLine());

double imc = peso / (altura * altura);

if (imc < 18.5)
    Console.WriteLine("Abaixo do peso!");
else 
    Console.WriteLine("Peso normal!");

Console.WriteLine(imc);