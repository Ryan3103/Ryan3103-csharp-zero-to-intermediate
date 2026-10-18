class Designer : Funcionario
{
    public Designer(string nome) : base(nome)
    {
    }

    public override string DescreverAtividade()
    {
    return "Criando layouts.";
    }
}