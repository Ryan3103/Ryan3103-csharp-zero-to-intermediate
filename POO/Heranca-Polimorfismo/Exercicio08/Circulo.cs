class Circulo : Forma
{
    public double Raio {get; private set;}

    public Circulo(double raio) : base("Círculo")
    {
        Raio = raio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }
}