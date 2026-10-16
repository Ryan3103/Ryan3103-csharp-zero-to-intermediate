List<Notificacao> notificacoes = new List<Notificacao>();

notificacoes.Add(new NotificacaoEmail("ana@email.com"));
notificacoes.Add(new NotificacaoSMS("3199999999"));
notificacoes.Add(new NotificacaoEmail("ryan@email.com"));
notificacoes.Add(new Notificacao("Destinatario genérico"));

foreach (Notificacao notificacao in notificacoes)
{
    Console.WriteLine($"{notificacao.Enviar()}");
}