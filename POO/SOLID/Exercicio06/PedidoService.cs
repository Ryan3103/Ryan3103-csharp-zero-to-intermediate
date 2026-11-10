class PedidoService
{
    private INotificador notificador;

    public PedidoService(INotificador notificador)
    {
        this.notificador = notificador;
    }

    public void ConfirmarPedido()
    {
        notificador.Enviar("Seu pedido foi confirmado!");
    }
}