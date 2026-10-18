class Desenvolvedor : Funcionario
{
    public Desenvolvedor(string nome) : base(nome)
    {
    }

    public override string DescreverAtividade()
    {
        return "Desenvolvendo sistemas.";
    }
}