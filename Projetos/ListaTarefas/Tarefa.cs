class Tarefa
{
    public string Descricao {get; private set;}
    public bool Concluida {get; private set;}

    public Tarefa (string descricao)
    {
        Descricao = descricao;
        Concluida = false;
    }

    public void Concluir()
    {
        Concluida = true;
    }
}