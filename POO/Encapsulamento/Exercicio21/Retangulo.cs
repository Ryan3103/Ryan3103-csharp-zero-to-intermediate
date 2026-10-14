class Retangulo
{
    private double largura;
    private double altura;

    public Retangulo(double largura, double altura)
    {
        {
            if (largura <= 0)
            {
                this.largura = 1;
            }
            else
            {
                this.largura = largura;
            }

            if (altura <= 0)
            {
                this.altura = 1;
            }
            else
            {
                this.altura = altura;
            }
        }
    }

    public double CalcularArea()
    {
        return largura * altura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (largura + altura);
    }

    public bool EhQuadrado()
    {
        return altura == largura;
    }

    public string ObterDescricao()
    {
        return $"Retangulo: {altura} x {largura}";
    }
}