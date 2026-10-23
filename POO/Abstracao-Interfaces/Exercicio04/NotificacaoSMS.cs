class NotificacaoSMS : INotificavel
{
    public void Enviar(string mensagem)
    {
        Console.WriteLine($"Enviando SMS: {mensagem}");
    }
}