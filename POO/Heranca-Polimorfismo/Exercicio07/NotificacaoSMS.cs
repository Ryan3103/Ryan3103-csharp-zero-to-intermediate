class NotificacaoSMS : Notificacao
{
    public NotificacaoSMS(string destinatario) : base(destinatario)
    {
    }
    public override string Enviar()
    {
        return $"SMS enviado para {Destinatario}";
    }
}