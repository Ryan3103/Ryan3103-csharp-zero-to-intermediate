class Livro
{
    public string Titulo { get; private set; }
    public string Autor { get; private set; }
    public bool Disponivel { get; private set; }

    public Livro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
        Disponivel = true;
    }

    public void Emprestar()
    {
        Disponivel = false;
    }

    public void Devolver()
    {
        Disponivel = true;
    }
}