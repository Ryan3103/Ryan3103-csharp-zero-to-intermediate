Console.WriteLine("Digite o tempo em segundos: ");
int segundos = int.Parse(Console.ReadLine());

int horas = segundos / 3600;
int minutos = (segundos % 3600) / 60;
int segsRestantes = segundos % 60;

Console.WriteLine($"{horas} horas,{minutos} minutos,{segsRestantes} Segundos");