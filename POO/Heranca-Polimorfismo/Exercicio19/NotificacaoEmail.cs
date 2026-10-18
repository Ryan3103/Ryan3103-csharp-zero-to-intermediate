class NotificacaoEmail : Notificacao
{
    public string Conteudo {get; protected set;}

    public NotificacaoEmail(string destinatario, string conteudo) : base(destinatario)
    {
        Conteudo = conteudo;
    }
    public override string Mensagem()
    {
        return $"E-mail: {Conteudo}";
        
    }
}