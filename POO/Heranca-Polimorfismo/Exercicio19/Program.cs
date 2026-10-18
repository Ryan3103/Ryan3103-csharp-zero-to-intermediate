List<Notificacao> notificacoes = new List<Notificacao>();

notificacoes.Add(new NotificacaoEmail("Ana", "Sua compra foi comfirmada."));
notificacoes.Add(new NotificacaoSMS("Bruno", "Seu código é 4821."));
notificacoes.Add(new NotificacaoEmail("Carla", "Seu pedido foi enviado."));

foreach (Notificacao notificacao in notificacoes)
{
    Console.WriteLine($"{notificacao.Destinatario} - {notificacao.Mensagem()}");
}