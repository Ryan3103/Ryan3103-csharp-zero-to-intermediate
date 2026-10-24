class ValidadorUsuario
{
    public bool Validar(Usuario usuario)
    {
        if (usuario.Nome == "")
        {
            return false;
        }

        if (usuario.Idade < 0)
        {
            return false;
        }

        return true;
    }
}