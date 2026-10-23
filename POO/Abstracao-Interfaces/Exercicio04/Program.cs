List<INotificavel> notificacao = new List<INotificavel>();

notificacao.Add(new NotificacaoEmail());
notificacao.Add(new NotificacaoSMS());

foreach (INotificavel notificavel in notificacao)
{
    notificavel.Enviar("Sua conta foi criada!");
}