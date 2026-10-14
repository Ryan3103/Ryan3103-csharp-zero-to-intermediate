class Verificador
{
    private int numero;

    public Verificador(int numero)
    {
        this.numero = numero;
    }

    public bool EhPar()
    {
        return numero % 2 == 0;
    }

    public bool EhPositivo()
    {
        return numero > 0;
    }

    public bool EhMultiploDeTres()
    {
        return numero % 3 == 0;
    }

    public string ObterClassificacao()
    {
        if (numero > 0)
        {
            return "Positivo";
        }
        else if (numero < 0)
        {
            return "Negativo";
        }
        else
        {
            return "Zero";
        }
    }
}