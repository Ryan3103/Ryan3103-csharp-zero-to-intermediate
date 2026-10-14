class Calculadora
{
    private double numero1;
    private double numero2;

    public Calculadora(double numero1, double numero2)
    {
        this.numero1 = numero1;
        this.numero2 = numero2;
    }

    public double Somar()
    {
        return numero1 + numero2;
    }

    public double Subtrair()
    {
        return numero1 - numero2;
    }

    public double Multiplicar()
    {
        return numero1 * numero2;
    }

    public double Dividir()
    {
        if (numero2 == 0)
        {
            return 0;
        }
        return numero1 / numero2;
    }
}