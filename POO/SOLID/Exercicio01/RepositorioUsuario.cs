class RepositorioUsuario
{
     public void SalvarEmArquivo(Usuario usuario)
{
    string dados = $"{usuario.Nome};{usuario.Email};{usuario.Idade}";
    File.WriteAllText("usuario.txt", dados);
}
}