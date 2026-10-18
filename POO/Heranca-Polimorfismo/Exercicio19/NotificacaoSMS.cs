class NotificacaoSMS : Notificacao
{
    public string Conteudo {get; protected set;}
    public NotificacaoSMS(string destinatario, string conteudo) : base(destinatario)
    {
        Conteudo = conteudo;
    }

    public override string Mensagem()
    {
        return $"SMS: {Conteudo}";
    }
}