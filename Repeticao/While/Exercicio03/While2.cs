Console.WriteLine("Digite uma senha: ");
int senha = int.Parse(Console.ReadLine());

while (senha != 1234) {
    Console.WriteLine("Senha incorreta. Digite novamente:");
    senha = int.Parse(Console.ReadLine()); 
    }

    Console.WriteLine("Acesso permitido!");