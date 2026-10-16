class NotificacaoEmail : Notificacao
{
    public NotificacaoEmail(string destinatario) : base(destinatario)
    {
    }

    public override string Enviar()
    {
        return $"E-mail enviado para {Destinatario}";
    }
}