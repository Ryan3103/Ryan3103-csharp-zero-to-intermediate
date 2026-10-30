Produto produto = new Produto("Ryan", 10, 1);

produto.AdicionarEstoque(5);
produto.RemoverEstoque(3);
produto.RemoverEstoque(20);
produto.AdicionarEstoque(0);

produto.ExibirInformacoes();