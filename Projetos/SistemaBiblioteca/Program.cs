Biblioteca biblioteca = new Biblioteca();

Livro livro1 = new Livro("C#", "João");
Livro livro2 = new Livro("SQL", "Maria");
Livro livro3 = new Livro("Clean Code", "Robert");

biblioteca.AdicionarLivro(livro1);
biblioteca.AdicionarLivro(livro2);
biblioteca.AdicionarLivro(livro3);
biblioteca.ExibirLivros();

Console.WriteLine("");

livro1.Emprestar();
biblioteca.ExibirLivros();

Console.WriteLine("");

livro1.Devolver();
biblioteca.ExibirLivros();