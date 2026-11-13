class Biblioteca
{
    List<Livro> livros = new List<Livro>();

    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
    }

    public void ExibirLivros()
    {
        foreach (Livro livro in livros)
        {
            Console.WriteLine($"{livro.Titulo} - Autor: {livro.Autor} - Disponível: {livro.Disponivel}");
        }
    }
}