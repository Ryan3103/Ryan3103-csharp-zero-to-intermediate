class NotificadorEmail : INotificador
{
    public void Enviar(string mensagem)
    {
        Console.WriteLine($"Enviando e-mail: {mensagem}");
    }
}