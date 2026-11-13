Evento evento1 = new Evento("Show de Rock", 80, 20);

Console.WriteLine($"Evento: {evento1.Nome}");
Console.WriteLine($"Ingressos disponíveis: {evento1.IngressoDisponiveis}");
Console.WriteLine($"Compra realizada: {evento1.ComprarIngresso(3)}");
Console.WriteLine($"Valor da compra: R$ {evento1.CalcularValorCompra(3):F2}");
Console.WriteLine($"Ingressos restantes: R$ {evento1.ConsultarDisponibilidade()}");