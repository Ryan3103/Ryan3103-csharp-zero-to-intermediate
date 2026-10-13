Livro livro = new Livro("Dom Casmurro", "Machado de Assis");

livro.MostrarDados();

livro.Emprestar();
livro.MostrarDados();

livro.Emprestar();
livro.MostrarDados();

livro.Devolver();
livro.MostrarDados();

livro.Titulo = "Oi";
livro.Autor = "AB";
livro.MostrarDados();