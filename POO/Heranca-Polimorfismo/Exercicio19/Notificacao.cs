class Notificacao
{
    public string Destinatario  {get; protected set;}

    public Notificacao(string destinatario)
    {
        Destinatario = destinatario;
    }

    public virtual string Mensagem()
    {
        return "Mensagem genérica";
    }
}