Usuario usuario = new Usuario("Ryan", "ryan@email.com", 18);

ValidadorUsuario validador = new ValidadorUsuario();
GerenciadorUsuario gerenciador = new GerenciadorUsuario();
RepositorioUsuario repositorio = new RepositorioUsuario();

if (validador.Validar(usuario))
{
    gerenciador.ExibirDados(usuario);
    repositorio.SalvarEmArquivo(usuario);

    Console.WriteLine("Usuário salvo com sucesso!");
}
else
{
    Console.WriteLine("Usuário inválido");
}