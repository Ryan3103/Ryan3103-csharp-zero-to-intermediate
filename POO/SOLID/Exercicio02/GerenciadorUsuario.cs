class GerenciadorUsuario
{
    public void ExibirDados(Usuario usuario)
    {
        Console.WriteLine($"Nome: {usuario.Nome}");
        Console.WriteLine($"E-mail: {usuario.Email}");
        Console.WriteLine($"Idade: {usuario.Idade}");
    }
}