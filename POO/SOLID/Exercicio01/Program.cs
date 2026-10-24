Usuario usuario = new Usuario("Ryan", "ryan@email.com", 18);

GerenciadorUsuario gerenciador = new GerenciadorUsuario();
gerenciador.ExibirDados(usuario);

RepositorioUsuario repositorio = new RepositorioUsuario();
repositorio.SalvarEmArquivo(usuario);