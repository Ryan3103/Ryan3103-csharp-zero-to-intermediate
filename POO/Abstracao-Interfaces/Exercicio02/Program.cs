List<INotificavel> notificacoes = new List<INotificavel>();

notificacoes.Add(new Email());
notificacoes.Add(new SMS());

foreach(INotificavel notificavel in notificacoes)
{
    notificavel.EnviarNotificacao();
}