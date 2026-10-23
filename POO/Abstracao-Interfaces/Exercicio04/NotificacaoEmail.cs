class NotificacaoEmail : INotificavel
{
    public void Enviar(string mensagem)
    {
        Console.WriteLine($"Enviando e-mail: {mensagem}");
    }
}