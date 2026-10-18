class Funcionario
{
    public string Nome {get; protected set;}

    public Funcionario(string nome)
    {
        Nome = nome;
    }

    public virtual string DescreverAtividade()
    {
        return "Mensagem genérica";
    }
}