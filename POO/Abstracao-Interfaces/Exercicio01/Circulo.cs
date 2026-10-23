class Circulo : Forma
{
    public double Raio { get; set; }

    public Circulo(double raio)
    {
        Raio = raio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Raio, 2);
    }
}