Produto produto = new Produto("Teclado", 150, 10);

produto.MostrarDados();

produto.AdicionarEstoque(20);
produto.MostrarDados();

produto.RetirarEstoque(5);
produto.MostrarDados();

produto.RetirarEstoque(100);
produto.AdicionarEstoque(-3);
produto.MostrarDados();

produto.Nome = "Oi";
produto.Preco = -50;
produto.MostrarDados();