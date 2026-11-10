INotificador email = new NotificadorEmail();
PedidoService pedido = new PedidoService(email);
pedido.ConfirmarPedido();

INotificador SMS = new NotificadorSMS();
PedidoService pedido1 = new PedidoService(SMS);
pedido1.ConfirmarPedido();