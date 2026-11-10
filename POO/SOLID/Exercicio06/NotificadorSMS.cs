class NotificadorSMS : INotificador
{
    public void Enviar(string mensagem)
    {
        Console.WriteLine($"Enviando SMS: {mensagem}");
    }
}