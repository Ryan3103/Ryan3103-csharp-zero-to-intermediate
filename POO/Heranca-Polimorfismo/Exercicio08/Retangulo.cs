class Retangulo : Forma
{
    public double Largura {get; private set;}
    public double Altura {get; private set;}

    public Retangulo(double largura, double altura) : base("Retângulo")
    {
        Largura = largura;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return Largura * Altura;
    }
}